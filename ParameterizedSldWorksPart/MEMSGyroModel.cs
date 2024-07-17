using SolidWorks.Interop.cosworks;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParameterizedSldWorksPart
{
    public class MEMSGyroModel
    {
        public static string _userPath = default;
        private string _path = _userPath + "\\Gyro-MEMS#2.SLDPRT";
        private string _resultPath = _userPath + "\\Results";
        private const string _partName = "Gyro-MEMS#2.SLDPRT";
        private const string _compName = "Gyro-MEMS#2";

        /*private static List<string> anchors = new List<string> 
        { 
            "A1-Top", "A1-Side", "A1-Bot",
            "A2-Top", "A2-Side", "A2-Bot",
            "A3-Top", "A3-Side", "A3-Bot",
            "A4-Top", "A4-Side", "A4-Bot",
            "A5-Top", "A5-Side", "A5-Bot",
            "A6-Top", "A6-Side", "A6-Bot",
            "A7-Top", "A7-Side", "A7-Bot",
            "A8-Top", "A8-Side", "A8-Bot"
        };*/

        public static List<string> anchors = new List<string>
        {
            "A1-Side", "A2-Side", "A3-Side",
            "A4-Side", "A5-Side", "A6-Side", 
            "A7-Side", "A8-Side"
        };

        public double length { get; set; }
        public double width { get; set; }
        public double height { get; set; }

        public static double lengthOrig = 0.41;
        public static double widthOrig = 0.36;
        public static double heightOrig = 0.04;

        public int resultNumOfFreq;
        public double resultUpperBound;

        public int nodesNumber;

        public MEMSGyroModel() { }

        SldWorks swApp;
        IModelDoc2 Part;
        Dimension myDimension;
        int errors, longwarnings, longstatus;
        bool status;

        CosmosWorks COSMOSWORKS = default(CosmosWorks);
        CwAddincallback COSMOSObject = default(CwAddincallback);
        CWModelDoc ActDoc = default(CWModelDoc);
        CWStudyManager StudyMngr = default(CWStudyManager);
        CWStudy Study = default(CWStudy);
        CWSolidManager SolidMgr = default(CWSolidManager);
        CWSolidComponent SolidComponent = default(CWSolidComponent);
        CWSolidBody SolidBody = default(CWSolidBody);
        CWMesh CwMesh = default(CWMesh);
        CWResults CWResult = default(CWResults);
        CWFrequencyStudyOptions FrequencyOptions = default(CWFrequencyStudyOptions);
        CWDynamicStudyOptions DynamicStudyOptions = default( CWDynamicStudyOptions);
        CWLoadsAndRestraintsManager LoadsAndRestraintsManager;

        private void OpenPart(string path, string partName)
        {
            if (swApp == null)
            {
                swApp = GetApplication.GetSwApp();
            }
            swApp.DocumentVisible(false, (int)swDocumentTypes_e.swDocPART);
            swApp.OpenDoc6(path, 1, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", ref errors, ref longwarnings);
            Part = (IModelDoc2)swApp.IActivateDoc2(partName, true, ref longstatus);
            swApp.DocumentVisible(true, (int)swDocumentTypes_e.swDocPART);
        }

        public void RebuildModel()
        {
            SldWorks swApp = GetApplication.GetSwApp();
            OpenPart(_path, _partName);

            double lengthCoef = length / lengthOrig;
            double widthCoef = width / widthOrig;
            double heightCoef = height / heightOrig;

            //Sketch 5 - Mid Spring Connection
            Part.IParameter("D7@Sketch5").SystemValue = 0.000193 * widthCoef;
            Part.IParameter("D8@Sketch5").SystemValue = 0.000219 * lengthCoef;

            Part.IParameter("D1@Sketch5").SystemValue = 0.00001 * lengthCoef;
            Part.IParameter("D2@Sketch5").SystemValue = 0.00001 * widthCoef;
            Part.IParameter("D11@Sketch5").SystemValue = 0.00001 * lengthCoef;
            Part.IParameter("D6@Sketch5").SystemValue = 0.00001 * widthCoef;
            Part.IParameter("D12@Sketch5").SystemValue = 0.00001 * lengthCoef;
            Part.IParameter("D4@Sketch5").SystemValue = 0.00001 * lengthCoef;
            Part.IParameter("D3@Sketch5").SystemValue = 0.000005 * widthCoef;
            Part.IParameter("D5@Sketch5").SystemValue = 0.000005 * widthCoef;
            Part.IParameter("D9@Sketch5").SystemValue = 0.00001 * lengthCoef;
            Part.IParameter("D10@Sketch5").SystemValue = 0.000015 * widthCoef;

            Part.IParameter("D1@Boss-Extrude5").SystemValue = 0.00004 * heightCoef;
            Part.EditRebuild3();

            //Sketch 4 - Anchors
            Part.IParameter("D1@Sketch4").SystemValue = 0.00005 * widthCoef;
            Part.IParameter("D2@Sketch4").SystemValue = 0.00005 * lengthCoef;
            Part.IParameter("D1@Boss-Extrude4").SystemValue = 0.00005 * heightCoef;
            Part.EditRebuild3();

            //Sketch 3 - Electrodes & Drive Springs
            Part.IParameter("D2@Sketch3").SystemValue = 0.00011 * lengthCoef;
            Part.IParameter("D7@Sketch3").SystemValue = 0.0001 * widthCoef;
            Part.IParameter("D3@Sketch3").SystemValue = 0.00002 * widthCoef;
            Part.IParameter("D6@Sketch3").SystemValue = 0.00002 * lengthCoef;
            Part.IParameter("D8@Sketch3").SystemValue = 0.00005 * lengthCoef;

            Part.IParameter("D4@Sketch3").SystemValue = 0.000181 * lengthCoef;
            Part.IParameter("D5@Sketch3").SystemValue = 0.00002 * widthCoef;

            Part.IParameter("D14@Sketch3").SystemValue = 0.00001 * widthCoef;
            Part.IParameter("D10@Sketch3").SystemValue = 0.00001 * widthCoef;

            Part.IParameter("D12@Sketch3").SystemValue = 0.00001 * lengthCoef;
            Part.IParameter("D13@Sketch3").SystemValue = 0.00001 * lengthCoef;
            Part.IParameter("D15@Sketch3").SystemValue = 0.00001 * lengthCoef;

            Part.IParameter("D1@Boss-Extrude3").SystemValue = 0.00004 * heightCoef;
            Part.EditRebuild3();

            //Sketch2 - Coriolis Force Frame
            Part.IParameter("D4@Sketch2").SystemValue = 0.00054 * widthCoef;
            Part.IParameter("D19@Sketch2").SystemValue = 0.00044 * widthCoef;
            Part.IParameter("D6@Sketch2").SystemValue = 0.00059 * lengthCoef;
            Part.IParameter("D20@Sketch2").SystemValue = 0.00004 * lengthCoef;

            Part.IParameter("D3@Sketch2").SystemValue = 0.00001 * lengthCoef;
            Part.IParameter("D16@Sketch2").SystemValue = 0.00005 * lengthCoef;
            Part.IParameter("D17@Sketch2").SystemValue = 0.00011 * widthCoef;
            Part.IParameter("D18@Sketch2").SystemValue = 0.00001 * widthCoef;

            Part.IParameter("D8@Sketch2").SystemValue = 0.000005 * lengthCoef;
            Part.IParameter("D7@Sketch2").SystemValue = 0.000015 * widthCoef;
            Part.IParameter("D14@Sketch2").SystemValue = 0.000005 * widthCoef;
            Part.IParameter("D11@Sketch2").SystemValue = 0.00002 * widthCoef;
            Part.IParameter("D10@Sketch2").SystemValue = 0.00001 * widthCoef;
            Part.IParameter("D13@Sketch2").SystemValue = 0.000005 * lengthCoef;
            Part.IParameter("D12@Sketch2").SystemValue = 0.000185 * lengthCoef;
            Part.IParameter("D15@Sketch2").SystemValue = 0.000005 * lengthCoef;

            Part.IParameter("D2@Sketch2").SystemValue = 0.00001 * lengthCoef;
            Part.IParameter("D5@Sketch2").SystemValue = 0.00003 * widthCoef;

            Part.IParameter("D1@Boss-Extrude2").SystemValue = 0.00004 * heightCoef;
            Part.EditRebuild3();

            //Sketch1 - Drive Mass
            Part.IParameter("D1@Sketch1").SystemValue = 0.00036 * widthCoef;
            Part.IParameter("D2@Sketch1").SystemValue = 0.00041 * lengthCoef;

            Part.IParameter("D3@Sketch1").SystemValue = 0.00033 * lengthCoef;
            Part.IParameter("D4@Sketch1").SystemValue = 0.00003 * widthCoef;
            Part.IParameter("D5@Sketch1").SystemValue = 0.00001 * widthCoef;
            Part.IParameter("D7@Sketch1").SystemValue = 0.00005 * widthCoef;

            Part.IParameter("D1@Boss-Extrude1").SystemValue = 0.00004 * heightCoef;
            Part.EditRebuild3();

            Directory.CreateDirectory(_resultPath);
            Part.SaveAs(new StringBuilder(_resultPath).Append("\\Gyroscope.stl").ToString());
                        
        }

        public void FrequencyModelSimulation(List<string> restraintFaces, string materialName, int upperBound, int numOfFreq, bool useBoundOrFreq)
        {
            int CompCount = default;
            object Freq;
            object MassPart;
            double el = 0;
            double tl = 0;

            if (Part == null)
            {
                OpenPart(_path, _partName);
            }

            // Get SOLIDWORKS Simulation object
            COSMOSObject = (CwAddincallback)swApp.GetAddInObject("CosmosWorks.CosmosWorks");
            if (COSMOSObject == null) MessageBox.Show("COSMOSObject object not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            COSMOSWORKS = COSMOSObject.CosmosWorks;
            if (COSMOSWORKS == null) MessageBox.Show("COSMOSWORKS object not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Get active document
            ActDoc = COSMOSWORKS.ActiveDoc;
            if (ActDoc == null) MessageBox.Show("No active document", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Delete all default static study plots from this model
            ActDoc.DeleteAllDefaultStaticStudyPlots();

            // Create new frequency study
            StudyMngr = ActDoc.StudyManager;
            if (StudyMngr == null) MessageBox.Show("No CWStudyManager object", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            StudyMngr.DeleteStudy("Frequency");
            Study = StudyMngr.CreateNewStudy3("Frequency", (int)swsAnalysisStudyType_e.swsAnalysisStudyTypeFrequency, (int)swsMeshType_e.swsMeshTypeSolid, out errors);
            if (Study == null) MessageBox.Show("Study not created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Get number of solid components
            SolidMgr = Study.SolidManager;
            if (SolidMgr == null) MessageBox.Show("No CWSolidManager object", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            /*CompCount = SolidMgr.ComponentCount;*/

            SolidMgr.SetLibraryMaterialToAllBodiesByCompName(_compName, "solidworks materials", materialName);

            // Adding restraints
            if (restraintFaces != null)
            {
                LoadsAndRestraintsManager = Study.LoadsAndRestraintsManager;
                IPartDoc PartDoc = (PartDoc)Part;
                object[] entities = new object[restraintFaces.Count - 1];
                for (int i = 0; i < restraintFaces.Count - 1; i++)
                {
                    entities[i] = PartDoc.GetEntityByName(restraintFaces[i], (int)swSelectType_e.swSelFACES);
                }
                if (restraintFaces.Last().Equals("Base-Bottom"))
                {
                    object[] entityRoller = new object[1];
                    entityRoller[0] = PartDoc.GetEntityByName(restraintFaces.Last(), (int)swSelectType_e.swSelFACES);
                    LoadsAndRestraintsManager.AddRestraint((int)swsRestraintType_e.swsRestraintTypeRoller, entityRoller, null, out errors);
                }
                if (entities.Length > 0)
                {
                    LoadsAndRestraintsManager.AddRestraint((int)swsRestraintType_e.swsRestraintTypeFixed, entities, null, out errors);
                }
                Part.ClearSelection();
            }

            // Set frequency study options
            FrequencyOptions = Study.FrequencyStudyOptions;
            if (FrequencyOptions == null)
                MessageBox.Show("No CWFrequencyStudyOptions object", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            string studyResultPath = new StringBuilder(FrequencyOptions.ResultFolder).Append("\\").Append("Frequency & Dynamic Analysis").ToString();
            Directory.CreateDirectory(studyResultPath);
            FrequencyOptions.ResultFolder = studyResultPath;

            if(useBoundOrFreq == true)
            {
                FrequencyOptions.Options = (int)swsFrequencyStudyOption_e.swsFrequencyStudyOptionUseUpperBoundFrequency;
                FrequencyOptions.UpperBoundFrequency = upperBound;
            }
            else
            {
                FrequencyOptions.Options = (int)swsFrequencyStudyOption_e.swsFrequencyStudyOptionNumberFrequencies;
                FrequencyOptions.NoOfFrequencies = numOfFreq;
            }

            // Set meshing
            CwMesh = Study.Mesh;
            if (CwMesh == null) MessageBox.Show("No mesh object", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            CwMesh.Quality = 0;
            CwMesh.GetDefaultElementSizeAndTolerance(0, out el, out tl);
            errors = Study.CreateMesh(0, el, tl);
            if (errors != 0) MessageBox.Show("Mesh failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            nodesNumber = CwMesh.NodeCount;

            // Run analysis
            errors = Study.RunAnalysis();
            if (errors != 0) MessageBox.Show("Analysis failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Get results: frequencies and mass participation factors
            CWResult = Study.Results;
            if (CWResult == null) MessageBox.Show("No result object", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            object[] TimeorFrequency = (object[])CWResult.GetTimeOrFrequencyAtEachStep(0, out errors);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < TimeorFrequency.Length; i++)
            {
                sb.Append($"Frequency for mode shape {i + 1}: {TimeorFrequency[i]}\n");
                if(i == TimeorFrequency.Length - 1)
                {
                    resultNumOfFreq = i + 1;
                    resultUpperBound = Convert.ToDouble(TimeorFrequency[i]);
                }
            }
            MessageBox.Show(sb.ToString(), "Resonant Frequencies");

            /*Freq = CWResult.GetResonantFrequencies(out errors);
            MassPart = CWResult.GetMassParticipation(out errors);

            Freq.ToString();
            MassPart.ToString();*/
        }

        public object[] HarmonicModelSimulation(string excitationFace, double numOfFreq, int numOfPoints, double dampingCoef)
        {
            //Copy Freq Study
            StudyMngr.DeleteStudy("Dynamic from [Frequency]");
            CWStudy harmonicStudy = StudyMngr.ConvertStudy("Frequency", 1, "Dynamic from [Frequency]", 8, "Default", 1, out errors);

            //Harmonic Study Options
            DynamicStudyOptions = harmonicStudy.DynamicStudyOptions;
            DynamicStudyOptions.SetFrequencyOption2((int)swsFrequencyStudyOption_e.swsFrequencyStudyOptionNumberFrequencies, numOfFreq);
            DynamicStudyOptions.SetHarmonicFrequencyUpperLimit2(Math.Ceiling(resultUpperBound));
            DynamicStudyOptions.SetHarmonicNoOfPoints2(numOfPoints);

            //Uniform Base Excitation Setting
            IPartDoc PartDoc = (PartDoc)Part;
            LoadsAndRestraintsManager = harmonicStudy.LoadsAndRestraintsManager;
            object entity = PartDoc.GetEntityByName(excitationFace, (int)swSelectType_e.swSelFACES);
            double acceleration = 0;
            switch (excitationFace)
            {
                case "Bottom-Side-Face":
                    acceleration = -1;
                    break;
                case "Top-Side-Face":
                    acceleration = 1;
                    break;
            }
            CWBaseExcitation cWBaseExcitation = LoadsAndRestraintsManager.AddUniformBaseExcitation(
                (int)swsBaseExcitationType_e.swsBaseExcitationType_Acceleration,
                entity,
                (int)swsAccelerationUnit_e.swsAccelerationUnit_MetersPerSquareSec,
                0, 0, 0, 0, 1, acceleration, out errors
            );

            //Damping Options
            CWDampingOptions DampingOptions = harmonicStudy.DampingOptions;
            DampingOptions.DampingType = (int)swsDampingType_e.swsDampingType_Modal;
            DampingOptions.ComputeFromMaterialDamping = 0;
            DampingOptions.ClearAllDampingRatios();
            object[] ratios = new object[] { 1, numOfFreq, dampingCoef };
            DampingOptions.SetDampingRatios(1, ratios);

            //Run Harmonic
            harmonicStudy.RunAnalysis();
            CWResult = harmonicStudy.Results;

            /*CWResult.GetMaximumAvailableSteps();*/
            

            /*CWPlot accelPlot = CWResult.CreatePlot(
                (int)swsPlotResultTypes_e.swsResultAcceleration,
                (int)swsAccelerationComponent_e.swsAccelerationComponentAZ,
                (int)swsAccelerationUnit_e.swsAccelerationUnit_MetersPerSquareSec, 
                false, out errors
            );*/

            object[] plotNames = CWResult.GetPlotNames();
            /*Directory.CreateDirectory(_resultPath);*/
            foreach ( var plot in plotNames)
            {
                CWResult.SavePlotsAseDrawings(_resultPath, plot.ToString(), plot.ToString());
            }

            object[] accelerationAtAllSteps = GetDataAtNode(1839);

            return accelerationAtAllSteps;

            /*StringBuilder accelSb = new StringBuilder();
            for (int i = 0; i < accelerationAtAllSteps.Length; i++)
            {
                accelSb.Append(accelerationAtAllSteps[i]).Append("\n");
            }
            MessageBox.Show(accelSb.ToString());*/
        }

        public dynamic GetDataAtNode(int nodeIndex)
        {
            return CWResult.GetAccelerationComponentForAllStepsAtNode(
                (int)swsAccelerationComponent_e.swsAccelerationComponentAZ,
                nodeIndex, null,
                (int)swsAccelerationUnit_e.swsAccelerationUnit_MetersPerSquareSec, out errors
            );
        }

    }
}

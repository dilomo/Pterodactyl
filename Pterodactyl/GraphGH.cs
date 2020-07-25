﻿using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace Pterodactyl
{
    public class GraphGH : GH_Component
    {
        public GraphGH()
          : base("Graph", "Graph",
              "Create graph, if you want to generate Report Part - set Path",
              "Pterodactyl", "Advanced Graphs")
        {
        }
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddBooleanParameter("Show Graph", "Show Graph", "Show graph", GH_ParamAccess.item);
            pManager.AddGenericParameter("Graph Items", "Graph Items", "Add graph items", GH_ParamAccess.item);
            pManager.AddGenericParameter("Graph Settings", "Graph Settings", "Add graph settings", GH_ParamAccess.item);
            pManager.AddTextParameter("Path", "Path", "Set path where graph should be saved as .png file" +
                                                      " if you want to save it, and/or if you want to create Report Part. Remember to end " +
                                                      "path with .png extension.", GH_ParamAccess.item, "");
        }
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Report Part", "Report Part", "Created part of the report", GH_ParamAccess.item);
        }
        protected override void SolveInstance(IGH_DataAccess DA)
        {

        }
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return null;
            }
        }
        public override Guid ComponentGuid
        {
            get { return new Guid("32ea2490-6ab7-4090-9de2-e2414d0932c0"); }
        }
    }
}
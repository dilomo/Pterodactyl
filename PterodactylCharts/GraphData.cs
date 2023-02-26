﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PterodactylCharts
{
    public class GraphData
    {
        public GraphData(List<List<double>> xValues, List<List<double>> yValues,
            List<string> valuesNames, List<DataType> dataTypes)
        {
            XValues = xValues;
            YValues = yValues;
            ValuesNames = valuesNames;
            DataTypes = dataTypes;

            if (XValues.Count != YValues.Count)
            {
                throw new ArgumentException("X Values tree should have the same number of branches like Y Values tree");
            }
            if (XValues.Count != ValuesNames.Count)
            {
                throw new ArgumentException("X Values tree's number of branches != Values Names elements of list");
            }
            if (XValues.Count != DataTypes.Count)
            {
                var names = "";
                foreach (var dt in dataTypes)
                {
                    names += dt.TypeOfData.ToString() + "\n";
                }
                throw new ArgumentException("X Values tree's number of branches != Data Types elements. Current values:\n" + names);
            }
            for (int i = 0; i < XValues.Count; i++)
            {
                if (XValues[i].Count != YValues[i].Count)
                {
                    throw new ArgumentException("Inside each branch of X Values and Y Values trees numbers of elements of lists should match");
                }
            }

            int index = 0;
            foreach (var dt in dataTypes)
            {
                if (dt.TypeOfData == Enums.TypeOfData.Scatter && dt.ScatterValues.Length != xValues[index].Count)
                    throw new ArgumentException("The Scater Params count should match the items in the corresponding X Values and Y Values' tree branch");
                index++;
            }

        }
        public override string ToString()
        {
            StringBuilder stringRepresentation = new StringBuilder();
            stringRepresentation.AppendFormat("Graph Data{0}Series of data: {1}", Environment.NewLine, ValuesNames.Count);
            return stringRepresentation.ToString();
        }

        public List<List<double>> XValues { get; set; }
        public List<List<double>> YValues { get; set; }
        public List<string> ValuesNames { get; set; }
        public List<DataType> DataTypes { get; set; }
    }
}

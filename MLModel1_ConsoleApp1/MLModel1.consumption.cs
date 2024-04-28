﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace MLModel1_ConsoleApp1
{
    public partial class MLModel1
    {
        /// <summary>
        /// model input class for MLModel1.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"ID")]
            public float ID { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"Brand")]
            public string Brand { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"Model")]
            public string Model { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"Year")]
            public float Year { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"Color")]
            public string Color { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"Mileage")]
            public float Mileage { get; set; }

            [LoadColumn(6)]
            [ColumnName(@"Price")]
            public float Price { get; set; }

            [LoadColumn(7)]
            [ColumnName(@"Condition")]
            public string Condition { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel1.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"ID")]
            public float ID { get; set; }

            [ColumnName(@"Brand")]
            public float[] Brand { get; set; }

            [ColumnName(@"Model")]
            public float[] Model { get; set; }

            [ColumnName(@"Year")]
            public float Year { get; set; }

            [ColumnName(@"Color")]
            public float[] Color { get; set; }

            [ColumnName(@"Mileage")]
            public float Mileage { get; set; }

            [ColumnName(@"Price")]
            public float Price { get; set; }

            [ColumnName(@"Condition")]
            public float[] Condition { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLModel1.mlnet");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);


        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

    }
}

﻿// This file was auto-generated by ML.NET Model Builder.
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace PersonalityType
{
    public partial class MLModel1
    {
        public const string RetrainFilePath =  @"C:\Users\Braeden\Downloads\archive\16P.csv";
        public const char RetrainSeparatorChar = ',';
        public const bool RetrainHasHeader =  true;

         /// <summary>
        /// Train a new model with the provided dataset.
        /// </summary>
        /// <param name="outputModelPath">File path for saving the model. Should be similar to "C:\YourPath\ModelName.mlnet"</param>
        /// <param name="inputDataFilePath">Path to the data file for training.</param>
        /// <param name="separatorChar">Separator character for delimited training file.</param>
        /// <param name="hasHeader">Boolean if training file has a header.</param>
        public static void Train(string outputModelPath, string inputDataFilePath = RetrainFilePath, char separatorChar = RetrainSeparatorChar, bool hasHeader = RetrainHasHeader)
        {
            var mlContext = new MLContext();

            var data = LoadIDataViewFromFile(mlContext, inputDataFilePath, separatorChar, hasHeader);
            var model = RetrainModel(mlContext, data);
            SaveModel(mlContext, model, data, outputModelPath);
        }

        /// <summary>
        /// Load an IDataView from a file path.
        /// </summary>
        /// <param name="mlContext">The common context for all ML.NET operations.</param>
        /// <param name="inputDataFilePath">Path to the data file for training.</param>
        /// <param name="separatorChar">Separator character for delimited training file.</param>
        /// <param name="hasHeader">Boolean if training file has a header.</param>
        /// <returns>IDataView with loaded training data.</returns>
        public static IDataView LoadIDataViewFromFile(MLContext mlContext, string inputDataFilePath, char separatorChar, bool hasHeader)
        {
            return mlContext.Data.LoadFromTextFile<ModelInput>(inputDataFilePath, separatorChar, hasHeader);
        }



        /// <summary>
        /// Save a model at the specified path.
        /// </summary>
        /// <param name="mlContext">The common context for all ML.NET operations.</param>
        /// <param name="model">Model to save.</param>
        /// <param name="data">IDataView used to train the model.</param>
        /// <param name="modelSavePath">File path for saving the model. Should be similar to "C:\YourPath\ModelName.mlnet.</param>
        public static void SaveModel(MLContext mlContext, ITransformer model, IDataView data, string modelSavePath)
        {
            // Pull the data schema from the IDataView used for training the model
            DataViewSchema dataViewSchema = data.Schema;

            using (var fs = File.Create(modelSavePath))
            {
                mlContext.Model.Save(model, dataViewSchema, fs);
            }
        }


        /// <summary>
        /// Retrains model using the pipeline generated as part of the training process.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <param name="trainData"></param>
        /// <returns></returns>
        public static ITransformer RetrainModel(MLContext mlContext, IDataView trainData)
        {
            var pipeline = BuildPipeline(mlContext);
            var model = pipeline.Fit(trainData);

            return model;
        }


        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"You regularly make new friends.", @"You regularly make new friends."),new InputOutputColumnPair(@"You spend a lot of your free time exploring various random topics that pique your interest", @"You spend a lot of your free time exploring various random topics that pique your interest"),new InputOutputColumnPair(@"Seeing other people cry can easily make you feel like you want to cry too", @"Seeing other people cry can easily make you feel like you want to cry too"),new InputOutputColumnPair(@"You often make a backup plan for a backup plan.", @"You often make a backup plan for a backup plan."),new InputOutputColumnPair(@"You usually stay calm, even under a lot of pressure", @"You usually stay calm, even under a lot of pressure"),new InputOutputColumnPair(@"At social events, you rarely try to introduce yourself to new people and mostly talk to the ones you already know", @"At social events, you rarely try to introduce yourself to new people and mostly talk to the ones you already know"),new InputOutputColumnPair(@"You prefer to completely finish one project before starting another.", @"You prefer to completely finish one project before starting another."),new InputOutputColumnPair(@"You are very sentimental.", @"You are very sentimental."),new InputOutputColumnPair(@"You like to use organizing tools like schedules and lists.", @"You like to use organizing tools like schedules and lists."),new InputOutputColumnPair(@"Even a small mistake can cause you to doubt your overall abilities and knowledge.", @"Even a small mistake can cause you to doubt your overall abilities and knowledge."),new InputOutputColumnPair(@"You feel comfortable just walking up to someone you find interesting and striking up a conversation.", @"You feel comfortable just walking up to someone you find interesting and striking up a conversation."),new InputOutputColumnPair(@"You are not too interested in discussing various interpretations and analyses of creative works.", @"You are not too interested in discussing various interpretations and analyses of creative works."),new InputOutputColumnPair(@"You are more inclined to follow your head than your heart.", @"You are more inclined to follow your head than your heart."),new InputOutputColumnPair(@"You usually prefer just doing what you feel like at any given moment instead of planning a particular daily routine.", @"You usually prefer just doing what you feel like at any given moment instead of planning a particular daily routine."),new InputOutputColumnPair(@"You rarely worry about whether you make a good impression on people you meet.", @"You rarely worry about whether you make a good impression on people you meet."),new InputOutputColumnPair(@"You enjoy participating in group activities.", @"You enjoy participating in group activities."),new InputOutputColumnPair(@"You like books and movies that make you come up with your own interpretation of the ending.", @"You like books and movies that make you come up with your own interpretation of the ending."),new InputOutputColumnPair(@"Your happiness comes more from helping others accomplish things than your own accomplishments.", @"Your happiness comes more from helping others accomplish things than your own accomplishments."),new InputOutputColumnPair(@"You are interested in so many things that you find it difficult to choose what to try next.", @"You are interested in so many things that you find it difficult to choose what to try next."),new InputOutputColumnPair(@"You are prone to worrying that things will take a turn for the worse.", @"You are prone to worrying that things will take a turn for the worse."),new InputOutputColumnPair(@"You avoid leadership roles in group settings.", @"You avoid leadership roles in group settings."),new InputOutputColumnPair(@"You are definitely not an artistic type of person.", @"You are definitely not an artistic type of person."),new InputOutputColumnPair(@"You think the world would be a better place if people relied more on rationality and less on their feelings.", @"You think the world would be a better place if people relied more on rationality and less on their feelings."),new InputOutputColumnPair(@"You prefer to do your chores before allowing yourself to relax.", @"You prefer to do your chores before allowing yourself to relax."),new InputOutputColumnPair(@"You enjoy watching people argue.", @"You enjoy watching people argue."),new InputOutputColumnPair(@"You tend to avoid drawing attention to yourself.", @"You tend to avoid drawing attention to yourself."),new InputOutputColumnPair(@"Your mood can change very quickly.", @"Your mood can change very quickly."),new InputOutputColumnPair(@"You lose patience with people who are not as efficient as you.", @"You lose patience with people who are not as efficient as you."),new InputOutputColumnPair(@"You often end up doing things at the last possible moment.", @"You often end up doing things at the last possible moment."),new InputOutputColumnPair(@"You have always been fascinated by the question of what, if anything, happens after death.", @"You have always been fascinated by the question of what, if anything, happens after death."),new InputOutputColumnPair(@"You usually prefer to be around others rather than on your own.", @"You usually prefer to be around others rather than on your own."),new InputOutputColumnPair(@"You become bored or lose interest when the discussion gets highly theoretical.", @"You become bored or lose interest when the discussion gets highly theoretical."),new InputOutputColumnPair(@"You find it easy to empathize with a person whose experiences are very different from yours.", @"You find it easy to empathize with a person whose experiences are very different from yours."),new InputOutputColumnPair(@"You usually postpone finalizing decisions for as long as possible.", @"You usually postpone finalizing decisions for as long as possible."),new InputOutputColumnPair(@"You rarely second-guess the choices that you have made.", @"You rarely second-guess the choices that you have made."),new InputOutputColumnPair(@"After a long and exhausting week, a lively social event is just what you need.", @"After a long and exhausting week, a lively social event is just what you need."),new InputOutputColumnPair(@"You enjoy going to art museums.", @"You enjoy going to art museums."),new InputOutputColumnPair(@"You often have a hard time understanding other people�s feelings.", @"You often have a hard time understanding other people�s feelings."),new InputOutputColumnPair(@"You like to have a to-do list for each day.", @"You like to have a to-do list for each day."),new InputOutputColumnPair(@"You rarely feel insecure.", @"You rarely feel insecure."),new InputOutputColumnPair(@"You avoid making phone calls.", @"You avoid making phone calls."),new InputOutputColumnPair(@"You often spend a lot of time trying to understand views that are very different from your own.", @"You often spend a lot of time trying to understand views that are very different from your own."),new InputOutputColumnPair(@"In your social circle, you are often the one who contacts your friends and initiates activities.", @"In your social circle, you are often the one who contacts your friends and initiates activities."),new InputOutputColumnPair(@"If your plans are interrupted, your top priority is to get back on track as soon as possible.", @"If your plans are interrupted, your top priority is to get back on track as soon as possible."),new InputOutputColumnPair(@"You are still bothered by mistakes that you made a long time ago.", @"You are still bothered by mistakes that you made a long time ago."),new InputOutputColumnPair(@"You rarely contemplate the reasons for human existence or the meaning of life.", @"You rarely contemplate the reasons for human existence or the meaning of life."),new InputOutputColumnPair(@"Your emotions control you more than you control them.", @"Your emotions control you more than you control them."),new InputOutputColumnPair(@"You take great care not to make people look bad, even when it is completely their fault.", @"You take great care not to make people look bad, even when it is completely their fault."),new InputOutputColumnPair(@"Your personal work style is closer to spontaneous bursts of energy than organized and consistent efforts.", @"Your personal work style is closer to spontaneous bursts of energy than organized and consistent efforts."),new InputOutputColumnPair(@"When someone thinks highly of you, you wonder how long it will take them to feel disappointed in you.", @"When someone thinks highly of you, you wonder how long it will take them to feel disappointed in you."),new InputOutputColumnPair(@"You would love a job that requires you to work alone most of the time.", @"You would love a job that requires you to work alone most of the time."),new InputOutputColumnPair(@"You believe that pondering abstract philosophical questions is a waste of time.", @"You believe that pondering abstract philosophical questions is a waste of time."),new InputOutputColumnPair(@"You feel more drawn to places with busy, bustling atmospheres than quiet, intimate places.", @"You feel more drawn to places with busy, bustling atmospheres than quiet, intimate places."),new InputOutputColumnPair(@"You know at first glance how someone is feeling.", @"You know at first glance how someone is feeling."),new InputOutputColumnPair(@"You often feel overwhelmed.", @"You often feel overwhelmed."),new InputOutputColumnPair(@"You complete things methodically without skipping over any steps.", @"You complete things methodically without skipping over any steps."),new InputOutputColumnPair(@"You are very intrigued by things labeled as controversial.", @"You are very intrigued by things labeled as controversial."),new InputOutputColumnPair(@"You would pass along a good opportunity if you thought someone else needed it more.", @"You would pass along a good opportunity if you thought someone else needed it more."),new InputOutputColumnPair(@"You struggle with deadlines.", @"You struggle with deadlines."),new InputOutputColumnPair(@"You feel confident that things will work out for you.", @"You feel confident that things will work out for you.")})      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Personality",outputColumnName:@"Personality"))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"You regularly make new friends.",@"You spend a lot of your free time exploring various random topics that pique your interest",@"Seeing other people cry can easily make you feel like you want to cry too",@"You often make a backup plan for a backup plan.",@"You usually stay calm, even under a lot of pressure",@"At social events, you rarely try to introduce yourself to new people and mostly talk to the ones you already know",@"You prefer to completely finish one project before starting another.",@"You are very sentimental.",@"You like to use organizing tools like schedules and lists.",@"Even a small mistake can cause you to doubt your overall abilities and knowledge.",@"You feel comfortable just walking up to someone you find interesting and striking up a conversation.",@"You are not too interested in discussing various interpretations and analyses of creative works.",@"You are more inclined to follow your head than your heart.",@"You usually prefer just doing what you feel like at any given moment instead of planning a particular daily routine.",@"You rarely worry about whether you make a good impression on people you meet.",@"You enjoy participating in group activities.",@"You like books and movies that make you come up with your own interpretation of the ending.",@"Your happiness comes more from helping others accomplish things than your own accomplishments.",@"You are interested in so many things that you find it difficult to choose what to try next.",@"You are prone to worrying that things will take a turn for the worse.",@"You avoid leadership roles in group settings.",@"You are definitely not an artistic type of person.",@"You think the world would be a better place if people relied more on rationality and less on their feelings.",@"You prefer to do your chores before allowing yourself to relax.",@"You enjoy watching people argue.",@"You tend to avoid drawing attention to yourself.",@"Your mood can change very quickly.",@"You lose patience with people who are not as efficient as you.",@"You often end up doing things at the last possible moment.",@"You have always been fascinated by the question of what, if anything, happens after death.",@"You usually prefer to be around others rather than on your own.",@"You become bored or lose interest when the discussion gets highly theoretical.",@"You find it easy to empathize with a person whose experiences are very different from yours.",@"You usually postpone finalizing decisions for as long as possible.",@"You rarely second-guess the choices that you have made.",@"After a long and exhausting week, a lively social event is just what you need.",@"You enjoy going to art museums.",@"You often have a hard time understanding other people�s feelings.",@"You like to have a to-do list for each day.",@"You rarely feel insecure.",@"You avoid making phone calls.",@"You often spend a lot of time trying to understand views that are very different from your own.",@"In your social circle, you are often the one who contacts your friends and initiates activities.",@"If your plans are interrupted, your top priority is to get back on track as soon as possible.",@"You are still bothered by mistakes that you made a long time ago.",@"You rarely contemplate the reasons for human existence or the meaning of life.",@"Your emotions control you more than you control them.",@"You take great care not to make people look bad, even when it is completely their fault.",@"Your personal work style is closer to spontaneous bursts of energy than organized and consistent efforts.",@"When someone thinks highly of you, you wonder how long it will take them to feel disappointed in you.",@"You would love a job that requires you to work alone most of the time.",@"You believe that pondering abstract philosophical questions is a waste of time.",@"You feel more drawn to places with busy, bustling atmospheres than quiet, intimate places.",@"You know at first glance how someone is feeling.",@"You often feel overwhelmed.",@"You complete things methodically without skipping over any steps.",@"You are very intrigued by things labeled as controversial.",@"You would pass along a good opportunity if you thought someone else needed it more.",@"You struggle with deadlines.",@"You feel confident that things will work out for you.",@"Personality"}))      
                                    .Append(mlContext.Regression.Trainers.FastForest(new FastForestRegressionTrainer.Options(){NumberOfTrees=4361,NumberOfLeaves=28,FeatureFraction=0.9113786F,LabelColumnName=@"Response Id",FeatureColumnName=@"Features"}));

            return pipeline;
        }
    }
 }

﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace PersonalityType
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
            [ColumnName(@"Response Id")]
            public float Response_Id { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"You regularly make new friends.")]
            public float You_regularly_make_new_friends_ { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"You spend a lot of your free time exploring various random topics that pique your interest")]
            public float You_spend_a_lot_of_your_free_time_exploring_various_random_topics_that_pique_your_interest { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"Seeing other people cry can easily make you feel like you want to cry too")]
            public float Seeing_other_people_cry_can_easily_make_you_feel_like_you_want_to_cry_too { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"You often make a backup plan for a backup plan.")]
            public float You_often_make_a_backup_plan_for_a_backup_plan_ { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"You usually stay calm, even under a lot of pressure")]
            public float You_usually_stay_calm__even_under_a_lot_of_pressure { get; set; }

            [LoadColumn(6)]
            [ColumnName(@"At social events, you rarely try to introduce yourself to new people and mostly talk to the ones you already know")]
            public float At_social_events__you_rarely_try_to_introduce_yourself_to_new_people_and_mostly_talk_to_the_ones_you_already_know { get; set; }

            [LoadColumn(7)]
            [ColumnName(@"You prefer to completely finish one project before starting another.")]
            public float You_prefer_to_completely_finish_one_project_before_starting_another_ { get; set; }

            [LoadColumn(8)]
            [ColumnName(@"You are very sentimental.")]
            public float You_are_very_sentimental_ { get; set; }

            [LoadColumn(9)]
            [ColumnName(@"You like to use organizing tools like schedules and lists.")]
            public float You_like_to_use_organizing_tools_like_schedules_and_lists_ { get; set; }

            [LoadColumn(10)]
            [ColumnName(@"Even a small mistake can cause you to doubt your overall abilities and knowledge.")]
            public float Even_a_small_mistake_can_cause_you_to_doubt_your_overall_abilities_and_knowledge_ { get; set; }

            [LoadColumn(11)]
            [ColumnName(@"You feel comfortable just walking up to someone you find interesting and striking up a conversation.")]
            public float You_feel_comfortable_just_walking_up_to_someone_you_find_interesting_and_striking_up_a_conversation_ { get; set; }

            [LoadColumn(12)]
            [ColumnName(@"You are not too interested in discussing various interpretations and analyses of creative works.")]
            public float You_are_not_too_interested_in_discussing_various_interpretations_and_analyses_of_creative_works_ { get; set; }

            [LoadColumn(13)]
            [ColumnName(@"You are more inclined to follow your head than your heart.")]
            public float You_are_more_inclined_to_follow_your_head_than_your_heart_ { get; set; }

            [LoadColumn(14)]
            [ColumnName(@"You usually prefer just doing what you feel like at any given moment instead of planning a particular daily routine.")]
            public float You_usually_prefer_just_doing_what_you_feel_like_at_any_given_moment_instead_of_planning_a_particular_daily_routine_ { get; set; }

            [LoadColumn(15)]
            [ColumnName(@"You rarely worry about whether you make a good impression on people you meet.")]
            public float You_rarely_worry_about_whether_you_make_a_good_impression_on_people_you_meet_ { get; set; }

            [LoadColumn(16)]
            [ColumnName(@"You enjoy participating in group activities.")]
            public float You_enjoy_participating_in_group_activities_ { get; set; }

            [LoadColumn(17)]
            [ColumnName(@"You like books and movies that make you come up with your own interpretation of the ending.")]
            public float You_like_books_and_movies_that_make_you_come_up_with_your_own_interpretation_of_the_ending_ { get; set; }

            [LoadColumn(18)]
            [ColumnName(@"Your happiness comes more from helping others accomplish things than your own accomplishments.")]
            public float Your_happiness_comes_more_from_helping_others_accomplish_things_than_your_own_accomplishments_ { get; set; }

            [LoadColumn(19)]
            [ColumnName(@"You are interested in so many things that you find it difficult to choose what to try next.")]
            public float You_are_interested_in_so_many_things_that_you_find_it_difficult_to_choose_what_to_try_next_ { get; set; }

            [LoadColumn(20)]
            [ColumnName(@"You are prone to worrying that things will take a turn for the worse.")]
            public float You_are_prone_to_worrying_that_things_will_take_a_turn_for_the_worse_ { get; set; }

            [LoadColumn(21)]
            [ColumnName(@"You avoid leadership roles in group settings.")]
            public float You_avoid_leadership_roles_in_group_settings_ { get; set; }

            [LoadColumn(22)]
            [ColumnName(@"You are definitely not an artistic type of person.")]
            public float You_are_definitely_not_an_artistic_type_of_person_ { get; set; }

            [LoadColumn(23)]
            [ColumnName(@"You think the world would be a better place if people relied more on rationality and less on their feelings.")]
            public float You_think_the_world_would_be_a_better_place_if_people_relied_more_on_rationality_and_less_on_their_feelings_ { get; set; }

            [LoadColumn(24)]
            [ColumnName(@"You prefer to do your chores before allowing yourself to relax.")]
            public float You_prefer_to_do_your_chores_before_allowing_yourself_to_relax_ { get; set; }

            [LoadColumn(25)]
            [ColumnName(@"You enjoy watching people argue.")]
            public float You_enjoy_watching_people_argue_ { get; set; }

            [LoadColumn(26)]
            [ColumnName(@"You tend to avoid drawing attention to yourself.")]
            public float You_tend_to_avoid_drawing_attention_to_yourself_ { get; set; }

            [LoadColumn(27)]
            [ColumnName(@"Your mood can change very quickly.")]
            public float Your_mood_can_change_very_quickly_ { get; set; }

            [LoadColumn(28)]
            [ColumnName(@"You lose patience with people who are not as efficient as you.")]
            public float You_lose_patience_with_people_who_are_not_as_efficient_as_you_ { get; set; }

            [LoadColumn(29)]
            [ColumnName(@"You often end up doing things at the last possible moment.")]
            public float You_often_end_up_doing_things_at_the_last_possible_moment_ { get; set; }

            [LoadColumn(30)]
            [ColumnName(@"You have always been fascinated by the question of what, if anything, happens after death.")]
            public float You_have_always_been_fascinated_by_the_question_of_what__if_anything__happens_after_death_ { get; set; }

            [LoadColumn(31)]
            [ColumnName(@"You usually prefer to be around others rather than on your own.")]
            public float You_usually_prefer_to_be_around_others_rather_than_on_your_own_ { get; set; }

            [LoadColumn(32)]
            [ColumnName(@"You become bored or lose interest when the discussion gets highly theoretical.")]
            public float You_become_bored_or_lose_interest_when_the_discussion_gets_highly_theoretical_ { get; set; }

            [LoadColumn(33)]
            [ColumnName(@"You find it easy to empathize with a person whose experiences are very different from yours.")]
            public float You_find_it_easy_to_empathize_with_a_person_whose_experiences_are_very_different_from_yours_ { get; set; }

            [LoadColumn(34)]
            [ColumnName(@"You usually postpone finalizing decisions for as long as possible.")]
            public float You_usually_postpone_finalizing_decisions_for_as_long_as_possible_ { get; set; }

            [LoadColumn(35)]
            [ColumnName(@"You rarely second-guess the choices that you have made.")]
            public float You_rarely_second_guess_the_choices_that_you_have_made_ { get; set; }

            [LoadColumn(36)]
            [ColumnName(@"After a long and exhausting week, a lively social event is just what you need.")]
            public float After_a_long_and_exhausting_week__a_lively_social_event_is_just_what_you_need_ { get; set; }

            [LoadColumn(37)]
            [ColumnName(@"You enjoy going to art museums.")]
            public float You_enjoy_going_to_art_museums_ { get; set; }

            [LoadColumn(38)]
            [ColumnName(@"You often have a hard time understanding other people�s feelings.")]
            public float You_often_have_a_hard_time_understanding_other_people_s_feelings_ { get; set; }

            [LoadColumn(39)]
            [ColumnName(@"You like to have a to-do list for each day.")]
            public float You_like_to_have_a_to_do_list_for_each_day_ { get; set; }

            [LoadColumn(40)]
            [ColumnName(@"You rarely feel insecure.")]
            public float You_rarely_feel_insecure_ { get; set; }

            [LoadColumn(41)]
            [ColumnName(@"You avoid making phone calls.")]
            public float You_avoid_making_phone_calls_ { get; set; }

            [LoadColumn(42)]
            [ColumnName(@"You often spend a lot of time trying to understand views that are very different from your own.")]
            public float You_often_spend_a_lot_of_time_trying_to_understand_views_that_are_very_different_from_your_own_ { get; set; }

            [LoadColumn(43)]
            [ColumnName(@"In your social circle, you are often the one who contacts your friends and initiates activities.")]
            public float In_your_social_circle__you_are_often_the_one_who_contacts_your_friends_and_initiates_activities_ { get; set; }

            [LoadColumn(44)]
            [ColumnName(@"If your plans are interrupted, your top priority is to get back on track as soon as possible.")]
            public float If_your_plans_are_interrupted__your_top_priority_is_to_get_back_on_track_as_soon_as_possible_ { get; set; }

            [LoadColumn(45)]
            [ColumnName(@"You are still bothered by mistakes that you made a long time ago.")]
            public float You_are_still_bothered_by_mistakes_that_you_made_a_long_time_ago_ { get; set; }

            [LoadColumn(46)]
            [ColumnName(@"You rarely contemplate the reasons for human existence or the meaning of life.")]
            public float You_rarely_contemplate_the_reasons_for_human_existence_or_the_meaning_of_life_ { get; set; }

            [LoadColumn(47)]
            [ColumnName(@"Your emotions control you more than you control them.")]
            public float Your_emotions_control_you_more_than_you_control_them_ { get; set; }

            [LoadColumn(48)]
            [ColumnName(@"You take great care not to make people look bad, even when it is completely their fault.")]
            public float You_take_great_care_not_to_make_people_look_bad__even_when_it_is_completely_their_fault_ { get; set; }

            [LoadColumn(49)]
            [ColumnName(@"Your personal work style is closer to spontaneous bursts of energy than organized and consistent efforts.")]
            public float Your_personal_work_style_is_closer_to_spontaneous_bursts_of_energy_than_organized_and_consistent_efforts_ { get; set; }

            [LoadColumn(50)]
            [ColumnName(@"When someone thinks highly of you, you wonder how long it will take them to feel disappointed in you.")]
            public float When_someone_thinks_highly_of_you__you_wonder_how_long_it_will_take_them_to_feel_disappointed_in_you_ { get; set; }

            [LoadColumn(51)]
            [ColumnName(@"You would love a job that requires you to work alone most of the time.")]
            public float You_would_love_a_job_that_requires_you_to_work_alone_most_of_the_time_ { get; set; }

            [LoadColumn(52)]
            [ColumnName(@"You believe that pondering abstract philosophical questions is a waste of time.")]
            public float You_believe_that_pondering_abstract_philosophical_questions_is_a_waste_of_time_ { get; set; }

            [LoadColumn(53)]
            [ColumnName(@"You feel more drawn to places with busy, bustling atmospheres than quiet, intimate places.")]
            public float You_feel_more_drawn_to_places_with_busy__bustling_atmospheres_than_quiet__intimate_places_ { get; set; }

            [LoadColumn(54)]
            [ColumnName(@"You know at first glance how someone is feeling.")]
            public float You_know_at_first_glance_how_someone_is_feeling_ { get; set; }

            [LoadColumn(55)]
            [ColumnName(@"You often feel overwhelmed.")]
            public float You_often_feel_overwhelmed_ { get; set; }

            [LoadColumn(56)]
            [ColumnName(@"You complete things methodically without skipping over any steps.")]
            public float You_complete_things_methodically_without_skipping_over_any_steps_ { get; set; }

            [LoadColumn(57)]
            [ColumnName(@"You are very intrigued by things labeled as controversial.")]
            public float You_are_very_intrigued_by_things_labeled_as_controversial_ { get; set; }

            [LoadColumn(58)]
            [ColumnName(@"You would pass along a good opportunity if you thought someone else needed it more.")]
            public float You_would_pass_along_a_good_opportunity_if_you_thought_someone_else_needed_it_more_ { get; set; }

            [LoadColumn(59)]
            [ColumnName(@"You struggle with deadlines.")]
            public float You_struggle_with_deadlines_ { get; set; }

            [LoadColumn(60)]
            [ColumnName(@"You feel confident that things will work out for you.")]
            public float You_feel_confident_that_things_will_work_out_for_you_ { get; set; }

            [LoadColumn(61)]
            [ColumnName(@"Personality")]
            public string Personality { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel1.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"Response Id")]
            public float Response_Id { get; set; }

            [ColumnName(@"You regularly make new friends.")]
            public float You_regularly_make_new_friends_ { get; set; }

            [ColumnName(@"You spend a lot of your free time exploring various random topics that pique your interest")]
            public float You_spend_a_lot_of_your_free_time_exploring_various_random_topics_that_pique_your_interest { get; set; }

            [ColumnName(@"Seeing other people cry can easily make you feel like you want to cry too")]
            public float Seeing_other_people_cry_can_easily_make_you_feel_like_you_want_to_cry_too { get; set; }

            [ColumnName(@"You often make a backup plan for a backup plan.")]
            public float You_often_make_a_backup_plan_for_a_backup_plan_ { get; set; }

            [ColumnName(@"You usually stay calm, even under a lot of pressure")]
            public float You_usually_stay_calm__even_under_a_lot_of_pressure { get; set; }

            [ColumnName(@"At social events, you rarely try to introduce yourself to new people and mostly talk to the ones you already know")]
            public float At_social_events__you_rarely_try_to_introduce_yourself_to_new_people_and_mostly_talk_to_the_ones_you_already_know { get; set; }

            [ColumnName(@"You prefer to completely finish one project before starting another.")]
            public float You_prefer_to_completely_finish_one_project_before_starting_another_ { get; set; }

            [ColumnName(@"You are very sentimental.")]
            public float You_are_very_sentimental_ { get; set; }

            [ColumnName(@"You like to use organizing tools like schedules and lists.")]
            public float You_like_to_use_organizing_tools_like_schedules_and_lists_ { get; set; }

            [ColumnName(@"Even a small mistake can cause you to doubt your overall abilities and knowledge.")]
            public float Even_a_small_mistake_can_cause_you_to_doubt_your_overall_abilities_and_knowledge_ { get; set; }

            [ColumnName(@"You feel comfortable just walking up to someone you find interesting and striking up a conversation.")]
            public float You_feel_comfortable_just_walking_up_to_someone_you_find_interesting_and_striking_up_a_conversation_ { get; set; }

            [ColumnName(@"You are not too interested in discussing various interpretations and analyses of creative works.")]
            public float You_are_not_too_interested_in_discussing_various_interpretations_and_analyses_of_creative_works_ { get; set; }

            [ColumnName(@"You are more inclined to follow your head than your heart.")]
            public float You_are_more_inclined_to_follow_your_head_than_your_heart_ { get; set; }

            [ColumnName(@"You usually prefer just doing what you feel like at any given moment instead of planning a particular daily routine.")]
            public float You_usually_prefer_just_doing_what_you_feel_like_at_any_given_moment_instead_of_planning_a_particular_daily_routine_ { get; set; }

            [ColumnName(@"You rarely worry about whether you make a good impression on people you meet.")]
            public float You_rarely_worry_about_whether_you_make_a_good_impression_on_people_you_meet_ { get; set; }

            [ColumnName(@"You enjoy participating in group activities.")]
            public float You_enjoy_participating_in_group_activities_ { get; set; }

            [ColumnName(@"You like books and movies that make you come up with your own interpretation of the ending.")]
            public float You_like_books_and_movies_that_make_you_come_up_with_your_own_interpretation_of_the_ending_ { get; set; }

            [ColumnName(@"Your happiness comes more from helping others accomplish things than your own accomplishments.")]
            public float Your_happiness_comes_more_from_helping_others_accomplish_things_than_your_own_accomplishments_ { get; set; }

            [ColumnName(@"You are interested in so many things that you find it difficult to choose what to try next.")]
            public float You_are_interested_in_so_many_things_that_you_find_it_difficult_to_choose_what_to_try_next_ { get; set; }

            [ColumnName(@"You are prone to worrying that things will take a turn for the worse.")]
            public float You_are_prone_to_worrying_that_things_will_take_a_turn_for_the_worse_ { get; set; }

            [ColumnName(@"You avoid leadership roles in group settings.")]
            public float You_avoid_leadership_roles_in_group_settings_ { get; set; }

            [ColumnName(@"You are definitely not an artistic type of person.")]
            public float You_are_definitely_not_an_artistic_type_of_person_ { get; set; }

            [ColumnName(@"You think the world would be a better place if people relied more on rationality and less on their feelings.")]
            public float You_think_the_world_would_be_a_better_place_if_people_relied_more_on_rationality_and_less_on_their_feelings_ { get; set; }

            [ColumnName(@"You prefer to do your chores before allowing yourself to relax.")]
            public float You_prefer_to_do_your_chores_before_allowing_yourself_to_relax_ { get; set; }

            [ColumnName(@"You enjoy watching people argue.")]
            public float You_enjoy_watching_people_argue_ { get; set; }

            [ColumnName(@"You tend to avoid drawing attention to yourself.")]
            public float You_tend_to_avoid_drawing_attention_to_yourself_ { get; set; }

            [ColumnName(@"Your mood can change very quickly.")]
            public float Your_mood_can_change_very_quickly_ { get; set; }

            [ColumnName(@"You lose patience with people who are not as efficient as you.")]
            public float You_lose_patience_with_people_who_are_not_as_efficient_as_you_ { get; set; }

            [ColumnName(@"You often end up doing things at the last possible moment.")]
            public float You_often_end_up_doing_things_at_the_last_possible_moment_ { get; set; }

            [ColumnName(@"You have always been fascinated by the question of what, if anything, happens after death.")]
            public float You_have_always_been_fascinated_by_the_question_of_what__if_anything__happens_after_death_ { get; set; }

            [ColumnName(@"You usually prefer to be around others rather than on your own.")]
            public float You_usually_prefer_to_be_around_others_rather_than_on_your_own_ { get; set; }

            [ColumnName(@"You become bored or lose interest when the discussion gets highly theoretical.")]
            public float You_become_bored_or_lose_interest_when_the_discussion_gets_highly_theoretical_ { get; set; }

            [ColumnName(@"You find it easy to empathize with a person whose experiences are very different from yours.")]
            public float You_find_it_easy_to_empathize_with_a_person_whose_experiences_are_very_different_from_yours_ { get; set; }

            [ColumnName(@"You usually postpone finalizing decisions for as long as possible.")]
            public float You_usually_postpone_finalizing_decisions_for_as_long_as_possible_ { get; set; }

            [ColumnName(@"You rarely second-guess the choices that you have made.")]
            public float You_rarely_second_guess_the_choices_that_you_have_made_ { get; set; }

            [ColumnName(@"After a long and exhausting week, a lively social event is just what you need.")]
            public float After_a_long_and_exhausting_week__a_lively_social_event_is_just_what_you_need_ { get; set; }

            [ColumnName(@"You enjoy going to art museums.")]
            public float You_enjoy_going_to_art_museums_ { get; set; }

            [ColumnName(@"You often have a hard time understanding other people�s feelings.")]
            public float You_often_have_a_hard_time_understanding_other_people_s_feelings_ { get; set; }

            [ColumnName(@"You like to have a to-do list for each day.")]
            public float You_like_to_have_a_to_do_list_for_each_day_ { get; set; }

            [ColumnName(@"You rarely feel insecure.")]
            public float You_rarely_feel_insecure_ { get; set; }

            [ColumnName(@"You avoid making phone calls.")]
            public float You_avoid_making_phone_calls_ { get; set; }

            [ColumnName(@"You often spend a lot of time trying to understand views that are very different from your own.")]
            public float You_often_spend_a_lot_of_time_trying_to_understand_views_that_are_very_different_from_your_own_ { get; set; }

            [ColumnName(@"In your social circle, you are often the one who contacts your friends and initiates activities.")]
            public float In_your_social_circle__you_are_often_the_one_who_contacts_your_friends_and_initiates_activities_ { get; set; }

            [ColumnName(@"If your plans are interrupted, your top priority is to get back on track as soon as possible.")]
            public float If_your_plans_are_interrupted__your_top_priority_is_to_get_back_on_track_as_soon_as_possible_ { get; set; }

            [ColumnName(@"You are still bothered by mistakes that you made a long time ago.")]
            public float You_are_still_bothered_by_mistakes_that_you_made_a_long_time_ago_ { get; set; }

            [ColumnName(@"You rarely contemplate the reasons for human existence or the meaning of life.")]
            public float You_rarely_contemplate_the_reasons_for_human_existence_or_the_meaning_of_life_ { get; set; }

            [ColumnName(@"Your emotions control you more than you control them.")]
            public float Your_emotions_control_you_more_than_you_control_them_ { get; set; }

            [ColumnName(@"You take great care not to make people look bad, even when it is completely their fault.")]
            public float You_take_great_care_not_to_make_people_look_bad__even_when_it_is_completely_their_fault_ { get; set; }

            [ColumnName(@"Your personal work style is closer to spontaneous bursts of energy than organized and consistent efforts.")]
            public float Your_personal_work_style_is_closer_to_spontaneous_bursts_of_energy_than_organized_and_consistent_efforts_ { get; set; }

            [ColumnName(@"When someone thinks highly of you, you wonder how long it will take them to feel disappointed in you.")]
            public float When_someone_thinks_highly_of_you__you_wonder_how_long_it_will_take_them_to_feel_disappointed_in_you_ { get; set; }

            [ColumnName(@"You would love a job that requires you to work alone most of the time.")]
            public float You_would_love_a_job_that_requires_you_to_work_alone_most_of_the_time_ { get; set; }

            [ColumnName(@"You believe that pondering abstract philosophical questions is a waste of time.")]
            public float You_believe_that_pondering_abstract_philosophical_questions_is_a_waste_of_time_ { get; set; }

            [ColumnName(@"You feel more drawn to places with busy, bustling atmospheres than quiet, intimate places.")]
            public float You_feel_more_drawn_to_places_with_busy__bustling_atmospheres_than_quiet__intimate_places_ { get; set; }

            [ColumnName(@"You know at first glance how someone is feeling.")]
            public float You_know_at_first_glance_how_someone_is_feeling_ { get; set; }

            [ColumnName(@"You often feel overwhelmed.")]
            public float You_often_feel_overwhelmed_ { get; set; }

            [ColumnName(@"You complete things methodically without skipping over any steps.")]
            public float You_complete_things_methodically_without_skipping_over_any_steps_ { get; set; }

            [ColumnName(@"You are very intrigued by things labeled as controversial.")]
            public float You_are_very_intrigued_by_things_labeled_as_controversial_ { get; set; }

            [ColumnName(@"You would pass along a good opportunity if you thought someone else needed it more.")]
            public float You_would_pass_along_a_good_opportunity_if_you_thought_someone_else_needed_it_more_ { get; set; }

            [ColumnName(@"You struggle with deadlines.")]
            public float You_struggle_with_deadlines_ { get; set; }

            [ColumnName(@"You feel confident that things will work out for you.")]
            public float You_feel_confident_that_things_will_work_out_for_you_ { get; set; }

            [ColumnName(@"Personality")]
            public float[] Personality { get; set; }

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
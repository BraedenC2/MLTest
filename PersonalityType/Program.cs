/*
 * Title: Machine Learning (Database) Personality Exam
 * Author: Braeden Connors
 * Database Set: https://www.kaggle.com/datasets/anshulmehtakaggl/60k-responses-of-16-personalities-test-mbt
 */


using PersonalityType;

namespace PersonalityType
{
    class Program
    {

        static void Main(string[] args)
        {
            float[] answerArray = new float[60];

            try
            {
                Console.WriteLine("Let's figure out your personality!");

                Console.WriteLine("""
        Fully Disagree      Mostly Disagree      Partially Disagree     Neutral     Partially Agree      Mostly Agree       Fully Agree
             -3                    -2                    -1                 0               1                  2                3

        """);

                Console.WriteLine("You regularly make new friends");
                answerArray[0] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You spend a lot of your free time exploring various random topics that pique your interest");
                answerArray[1] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Seeing other people cry can easily make you feel like you want to cry too");
                answerArray[2] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You often make a backup plan for a backup plan");
                answerArray[3] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You usually stay calm, even under a lot of pressure");
                answerArray[4] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("At social events, you rarely try to introduce yourself to new people and mostly talk to the ones you already know");
                answerArray[5] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You prefer to completely finish one project before starting another");
                answerArray[6] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You are very sentimental");
                answerArray[7] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You like to use organizing tools like schedules and lists");
                answerArray[8] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Even a small mistake can cause you to doubt your overall abilities and knowledge");
                answerArray[9] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You feel comfortable just walking up to someone you find interesting and striking up a conversation");
                answerArray[10] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You are not too interested in discussing various interpretations and analyses of creative works");
                answerArray[11] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You are more inclined to follow your head than your heart");
                answerArray[12] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You usually prefer just doing what you feel like at any given moment instead of planning a particular daily routine");
                answerArray[13] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You rarely worry about whether you make a good impression on people you meet");
                answerArray[14] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You enjoy participating in group activities");
                answerArray[15] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You like books and movies that make you come up with your own interpretation of the ending");
                answerArray[16] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Your happiness comes more from helping others accomplish things than your own accomplishments");
                answerArray[17] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You are interested in so many things that you find it difficult to choose what to try next");
                answerArray[18] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You are prone to worrying that things will take a turn for the worse");
                answerArray[19] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You avoid leadership roles in group settings");
                answerArray[20] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You are definitely not an artistic type of person");
                answerArray[21] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You think the world would be a better place if people relied more on rationality and less on their feelings");
                answerArray[22] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You prefer to do your chores before allowing yourself to relax");
                answerArray[23] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You enjoy watching people argue");
                answerArray[24] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You tend to avoid drawing attention to yourself");
                answerArray[25] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Your mood can change very quickly");
                answerArray[26] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You lose patience with people who are not as efficient as you");
                answerArray[27] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You often end up doing things at the last possible moment");
                answerArray[28] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You have always been fascinated by the question of what, if anything, happens after death");
                answerArray[29] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You usually prefer to be around others rather than on your own");
                answerArray[30] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You become bored or lose interest when the discussion gets highly theoretical");
                answerArray[31] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You find it easy to empathize with a person whose experiences are very different from yours");
                answerArray[32] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You usually postpone finalizing decisions for as long as possible");
                answerArray[33] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You rarely second guess the choices that you have made");
                answerArray[34] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("After a long and exhausting week, a lively social event is just what you need");
                answerArray[35] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You enjoy going to art museums");
                answerArray[36] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You often have a hard time understanding other people's feelings");
                answerArray[37] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You like to have a to-do list for each day");
                answerArray[38] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You rarely feel insecure");
                answerArray[39] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You avoid making phone calls");
                answerArray[40] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You often spend a lot of time trying to understand views that are very different from your own");
                answerArray[41] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("In your social circle, you are often the one who contacts your friends and initiates activities");
                answerArray[42] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("If your plans are interrupted, your top priority is to get back on track as soon as possible");
                answerArray[43] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You are still bothered by mistakes that you made a long time ago");
                answerArray[44] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You rarely contemplate the reasons for human existence or the meaning of life");
                answerArray[45] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Your emotions control you more than you control them");
                answerArray[46] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You take great care not to make people look bad, even when it is completely their fault");
                answerArray[47] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Your personal work style is closer to spontaneous bursts of energy than organized and consistent efforts");
                answerArray[48] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("When someone thinks highly of you, you wonder how long it will take them to feel disappointed in you");
                answerArray[49] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You would love a job that requires you to work alone most of the time");
                answerArray[50] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You believe that pondering abstract philosophical questions is a waste of time");
                answerArray[51] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You feel more drawn to places with busy, bustling atmospheres than quiet, intimate places");
                answerArray[52] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You know at first glance how someone is feeling");
                answerArray[53] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You often feel overwhelmed");
                answerArray[54] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You complete things methodically without skipping over any steps");
                answerArray[55] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You are very intrigued by things labeled as controversial");
                answerArray[56] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You would pass along a good opportunity if you thought someone else needed it more");
                answerArray[57] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You struggle with deadlines");
                answerArray[58] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You feel confident that things will work out for you");
                answerArray[59] = Convert.ToInt16(Console.ReadLine());


            }
            catch (Exception e) { }

            // Create single instance of sample data from first line of dataset for model input
            MLModel2.ModelInput userData = new MLModel2.ModelInput()
            {
                Response_Id = 1F,
                You_regularly_make_new_friends_ = answerArray[0],
                You_spend_a_lot_of_your_free_time_exploring_various_random_topics_that_pique_your_interest = answerArray[1],
                Seeing_other_people_cry_can_easily_make_you_feel_like_you_want_to_cry_too = answerArray[2],
                You_often_make_a_backup_plan_for_a_backup_plan_ = answerArray[3],
                You_usually_stay_calm__even_under_a_lot_of_pressure = answerArray[4],
                At_social_events__you_rarely_try_to_introduce_yourself_to_new_people_and_mostly_talk_to_the_ones_you_already_know = answerArray[5],
                You_prefer_to_completely_finish_one_project_before_starting_another_ = answerArray[6],
                You_are_very_sentimental_ = answerArray[7],
                You_like_to_use_organizing_tools_like_schedules_and_lists_ = answerArray[8],
                Even_a_small_mistake_can_cause_you_to_doubt_your_overall_abilities_and_knowledge_ = answerArray[9],
                You_feel_comfortable_just_walking_up_to_someone_you_find_interesting_and_striking_up_a_conversation_ = answerArray[10],
                You_are_not_too_interested_in_discussing_various_interpretations_and_analyses_of_creative_works_ = answerArray[11],
                You_are_more_inclined_to_follow_your_head_than_your_heart_ = answerArray[12],
                You_usually_prefer_just_doing_what_you_feel_like_at_any_given_moment_instead_of_planning_a_particular_daily_routine_ = answerArray[13],
                You_rarely_worry_about_whether_you_make_a_good_impression_on_people_you_meet_ = answerArray[14],
                You_enjoy_participating_in_group_activities_ = answerArray[15],
                You_like_books_and_movies_that_make_you_come_up_with_your_own_interpretation_of_the_ending_ = answerArray[16],
                Your_happiness_comes_more_from_helping_others_accomplish_things_than_your_own_accomplishments_ = answerArray[17],
                You_are_interested_in_so_many_things_that_you_find_it_difficult_to_choose_what_to_try_next_ = answerArray[18],
                You_are_prone_to_worrying_that_things_will_take_a_turn_for_the_worse_ = answerArray[19],
                You_avoid_leadership_roles_in_group_settings_ = answerArray[20],
                You_are_definitely_not_an_artistic_type_of_person_ = answerArray[21],
                You_think_the_world_would_be_a_better_place_if_people_relied_more_on_rationality_and_less_on_their_feelings_ = answerArray[22],
                You_prefer_to_do_your_chores_before_allowing_yourself_to_relax_ = answerArray[23],
                You_enjoy_watching_people_argue_ = answerArray[24],
                You_tend_to_avoid_drawing_attention_to_yourself_ = answerArray[25],
                Your_mood_can_change_very_quickly_ = answerArray[26],
                You_lose_patience_with_people_who_are_not_as_efficient_as_you_ = answerArray[27],
                You_often_end_up_doing_things_at_the_last_possible_moment_ = answerArray[28],
                You_have_always_been_fascinated_by_the_question_of_what__if_anything__happens_after_death_ = answerArray[29],
                You_usually_prefer_to_be_around_others_rather_than_on_your_own_ = answerArray[30],
                You_become_bored_or_lose_interest_when_the_discussion_gets_highly_theoretical_ = answerArray[31],
                You_find_it_easy_to_empathize_with_a_person_whose_experiences_are_very_different_from_yours_ = answerArray[32],
                You_usually_postpone_finalizing_decisions_for_as_long_as_possible_ = answerArray[33],
                You_rarely_second_guess_the_choices_that_you_have_made_ = answerArray[34],
                After_a_long_and_exhausting_week__a_lively_social_event_is_just_what_you_need_ = answerArray[35],
                You_enjoy_going_to_art_museums_ = answerArray[36],
                You_often_have_a_hard_time_understanding_other_people_s_feelings_ = answerArray[37],
                You_like_to_have_a_to_do_list_for_each_day_ = answerArray[38],
                You_rarely_feel_insecure_ = answerArray[39],
                You_avoid_making_phone_calls_ = answerArray[40],
                You_often_spend_a_lot_of_time_trying_to_understand_views_that_are_very_different_from_your_own_ = answerArray[41],
                In_your_social_circle__you_are_often_the_one_who_contacts_your_friends_and_initiates_activities_ = answerArray[42],
                If_your_plans_are_interrupted__your_top_priority_is_to_get_back_on_track_as_soon_as_possible_ = answerArray[43],
                You_are_still_bothered_by_mistakes_that_you_made_a_long_time_ago_ = answerArray[44],
                You_rarely_contemplate_the_reasons_for_human_existence_or_the_meaning_of_life_ = answerArray[45],
                Your_emotions_control_you_more_than_you_control_them_ = answerArray[46],
                You_take_great_care_not_to_make_people_look_bad__even_when_it_is_completely_their_fault_ = answerArray[47],
                Your_personal_work_style_is_closer_to_spontaneous_bursts_of_energy_than_organized_and_consistent_efforts_ = answerArray[48],
                When_someone_thinks_highly_of_you__you_wonder_how_long_it_will_take_them_to_feel_disappointed_in_you_ = answerArray[49],
                You_would_love_a_job_that_requires_you_to_work_alone_most_of_the_time_ = answerArray[50],
                You_believe_that_pondering_abstract_philosophical_questions_is_a_waste_of_time_ = answerArray[51],
                You_feel_more_drawn_to_places_with_busy__bustling_atmospheres_than_quiet__intimate_places_ = answerArray[52],
                You_know_at_first_glance_how_someone_is_feeling_ = answerArray[53],
                You_often_feel_overwhelmed_ = answerArray[54],
                You_complete_things_methodically_without_skipping_over_any_steps_ = answerArray[55],
                You_are_very_intrigued_by_things_labeled_as_controversial_ = answerArray[56],
                You_would_pass_along_a_good_opportunity_if_you_thought_someone_else_needed_it_more_ = answerArray[57],
                You_struggle_with_deadlines_ = answerArray[58],
                You_feel_confident_that_things_will_work_out_for_you_ = answerArray[59],
            };

            /*MLModel2.ModelInput sampleData = new MLModel2.ModelInput()
            {
                Response_Id = 1F,
                You_regularly_make_new_friends_ = 0,
                You_spend_a_lot_of_your_free_time_exploring_various_random_topics_that_pique_your_interest = 3F,
                Seeing_other_people_cry_can_easily_make_you_feel_like_you_want_to_cry_too = -2F,
                You_often_make_a_backup_plan_for_a_backup_plan_ = 2F,
                You_usually_stay_calm__even_under_a_lot_of_pressure = 3F,
                At_social_events__you_rarely_try_to_introduce_yourself_to_new_people_and_mostly_talk_to_the_ones_you_already_know = 3F,
                You_prefer_to_completely_finish_one_project_before_starting_another_ = 3F,
                You_are_very_sentimental_ = 0F,
                You_like_to_use_organizing_tools_like_schedules_and_lists_ = 2F,
                Even_a_small_mistake_can_cause_you_to_doubt_your_overall_abilities_and_knowledge_ = 1F,
                You_feel_comfortable_just_walking_up_to_someone_you_find_interesting_and_striking_up_a_conversation_ = -2F,
                You_are_not_too_interested_in_discussing_various_interpretations_and_analyses_of_creative_works_ = -2F,
                You_are_more_inclined_to_follow_your_head_than_your_heart_ = 2F,
                You_usually_prefer_just_doing_what_you_feel_like_at_any_given_moment_instead_of_planning_a_particular_daily_routine_ = 0F,
                You_rarely_worry_about_whether_you_make_a_good_impression_on_people_you_meet_ = 2F,
                You_enjoy_participating_in_group_activities_ = -2F,
                You_like_books_and_movies_that_make_you_come_up_with_your_own_interpretation_of_the_ending_ = 2F,
                Your_happiness_comes_more_from_helping_others_accomplish_things_than_your_own_accomplishments_ = 1F,
                You_are_interested_in_so_many_things_that_you_find_it_difficult_to_choose_what_to_try_next_ = 2F,
                You_are_prone_to_worrying_that_things_will_take_a_turn_for_the_worse_ = 1F,
                You_avoid_leadership_roles_in_group_settings_ = 1F,
                You_are_definitely_not_an_artistic_type_of_person_ = 0F,
                You_think_the_world_would_be_a_better_place_if_people_relied_more_on_rationality_and_less_on_their_feelings_ = 2F,
                You_prefer_to_do_your_chores_before_allowing_yourself_to_relax_ = 2F,
                You_enjoy_watching_people_argue_ = 0F,
                You_tend_to_avoid_drawing_attention_to_yourself_ = 3F,
                Your_mood_can_change_very_quickly_ = -2F,
                You_lose_patience_with_people_who_are_not_as_efficient_as_you_ = 2F,
                You_often_end_up_doing_things_at_the_last_possible_moment_ = -2F,
                You_have_always_been_fascinated_by_the_question_of_what__if_anything__happens_after_death_ = 3F,
                You_usually_prefer_to_be_around_others_rather_than_on_your_own_ = -1F,
                You_become_bored_or_lose_interest_when_the_discussion_gets_highly_theoretical_ = -2F,
                You_find_it_easy_to_empathize_with_a_person_whose_experiences_are_very_different_from_yours_ = 0F,
                You_usually_postpone_finalizing_decisions_for_as_long_as_possible_ = -1F,
                You_rarely_second_guess_the_choices_that_you_have_made_ = -1F,
                After_a_long_and_exhausting_week__a_lively_social_event_is_just_what_you_need_ = -3F,
                You_enjoy_going_to_art_museums_ = 2F,
                You_often_have_a_hard_time_understanding_other_people_s_feelings_ = 2F,
                You_like_to_have_a_to_do_list_for_each_day_ = 0F,
                You_rarely_feel_insecure_ = 2F,
                You_avoid_making_phone_calls_ = 2F,
                You_often_spend_a_lot_of_time_trying_to_understand_views_that_are_very_different_from_your_own_ = 2F,
                In_your_social_circle__you_are_often_the_one_who_contacts_your_friends_and_initiates_activities_ = 0F,
                If_your_plans_are_interrupted__your_top_priority_is_to_get_back_on_track_as_soon_as_possible_ = 1F,
                You_are_still_bothered_by_mistakes_that_you_made_a_long_time_ago_ = 1F,
                You_rarely_contemplate_the_reasons_for_human_existence_or_the_meaning_of_life_ = -2F,
                Your_emotions_control_you_more_than_you_control_them_ = -2F,
                You_take_great_care_not_to_make_people_look_bad__even_when_it_is_completely_their_fault_ = 0F,
                Your_personal_work_style_is_closer_to_spontaneous_bursts_of_energy_than_organized_and_consistent_efforts_ = -1F,
                When_someone_thinks_highly_of_you__you_wonder_how_long_it_will_take_them_to_feel_disappointed_in_you_ = 0F,
                You_would_love_a_job_that_requires_you_to_work_alone_most_of_the_time_ = 2F,
                You_believe_that_pondering_abstract_philosophical_questions_is_a_waste_of_time_ = -3F,
                You_feel_more_drawn_to_places_with_busy__bustling_atmospheres_than_quiet__intimate_places_ = -2F,
                You_know_at_first_glance_how_someone_is_feeling_ = 0F,
                You_often_feel_overwhelmed_ = -1F,
                You_complete_things_methodically_without_skipping_over_any_steps_ = 0F,
                You_are_very_intrigued_by_things_labeled_as_controversial_ = 1F,
                You_would_pass_along_a_good_opportunity_if_you_thought_someone_else_needed_it_more_ = 0F,
                You_struggle_with_deadlines_ = -2F,
                You_feel_confident_that_things_will_work_out_for_you_ = 2F,
            };*/



            Console.WriteLine("Using model to make single prediction -- Comparing actual Personality with predicted Personality from sample data...\n\n");




            var sortedScoresWithLabel = MLModel2.PredictAllLabels(userData);
            Console.WriteLine($"{"Class",-40}{"Score",-20}");
            Console.WriteLine($"{"-----",-40}{"-----",-20}");

            string firstScoreKey = null;
            foreach (var score in sortedScoresWithLabel)
            {
                if (firstScoreKey == null)
                {
                    firstScoreKey = score.Key;
                }
                Console.WriteLine($"{score.Key,-40}{score.Value,-20}");
            }

            Console.WriteLine("\n\n\n");



            switch (firstScoreKey)
            {
                case "ESTJ":
                    Console.WriteLine("You are: The Supervisor", -30);
                    break;
                case "ENTJ":
                    Console.WriteLine("You are: The Commander", -30);
                    break;
                case "ESFJ":
                    Console.WriteLine("You are: The Provider", -30);
                    break;
                case "ENFJ":
                    Console.WriteLine("You are: The Giver", -30);
                    break;
                case "ISTJ":
                    Console.WriteLine("You are: The Inspector", -30);
                    break;
                case "ISFJ":
                    Console.WriteLine("You are: The Nurturer", -30);
                    break;
                case "INTJ":
                    Console.WriteLine("You are: The Mastermind", -30);
                    break;
                case "INFJ":
                    Console.WriteLine("You are: The Counselor", -30);
                    break;
                case "ESTP":
                    Console.WriteLine("You are: The Doer", -30);
                    break;
                case "ESFP":
                    Console.WriteLine("You are: The Performer", -30);
                    break;
                case "ENTP":
                    Console.WriteLine("You are: The Visionary", -30);
                    break;
                case "ENFP":
                    Console.WriteLine("You are: The Champion", -30);
                    break;
                case "ISTP":
                    Console.WriteLine("You are: The Craftsman", -30);
                    break;
                case "ISFP":
                    Console.WriteLine("You are: The Composer", -30);
                    break;
                case "INTP":
                    Console.WriteLine("You are: The Thinker", -30);
                    break;
                case "INFP":
                    Console.WriteLine("You are: The Idealist", -30);
                    break;
                default:
                    Console.WriteLine("Error", -30);
                    break;
            }

            Ending();
        }

        static void Ending()
        {
            Console.WriteLine("Would you like to see the definitions? (Y|N):");
            try
            {
                String userIn = "";
                userIn = Console.ReadLine();
                userIn = userIn.ToUpper();
                if (userIn == "Y")
                {
                    Definitions();
                }
                else if (userIn == "N")
                {
                    Console.WriteLine("=============== End of process, hit any key to finish ===============");
                    Console.ReadKey();
                } else if (userIn == "R")
                {

                }
                else
                {
                    Console.WriteLine("Let's try that again.");
                    Ending();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Let's try that again.");
                Ending();
            }
        }

        static void Definitions()
        {

            Console.WriteLine("""
                ESTJ: The Supervisor. They are practical, realistic, and organized. They value tradition, loyalty, and responsibility. They are excellent administrators who can manage things and people efficiently.
                ENTJ: The Commander. They are bold, imaginative, and strong-willed. They have a clear vision of what they want to achieve and how to do it. They are natural leaders who can inspire and motivate others.
                ESFJ: The Provider. They are warm, caring, and sociable. They value harmony, cooperation, and generosity. They are extraordinarily helpful and attentive to the needs of others.
                ENFJ: The Giver. They are charismatic, empathetic, and persuasive. They value meaning, connection, and growth. They are influential and inspiring communicators who can bring out the best in others.
                ISTJ: The Inspector. They are quiet, serious, and dependable. They value facts, logic, and order. They are thorough and meticulous in their work and expect the same from others.
                ISFJ: The Nurturer. They are kind, loyal, and conscientious. They value stability, security, and harmony. They are devoted and supportive to their loved ones and their causes.
                INTJ: The Mastermind. They are original, analytical, and visionary. They value knowledge, competence, and innovation. They are strategic and independent thinkers who can solve complex problems with ease.
                INFJ: The Counselor. They are quiet, insightful, and idealistic. They value integrity, authenticity, and wisdom. They are creative and compassionate counselors who can understand and help others.
                ESTP: The Doer. They are energetic, adventurous, and pragmatic. They value action, fun, and variety. They are skillful and adaptable doers who can handle any situation.
                ESFP: The Performer. They are spontaneous, enthusiastic, and expressive. They value enjoyment, excitement, and popularity. They are charming and lively performers who can entertain and delight others.
                ENTP: The Visionary. They are smart, curious, and inventive. They value challenge, creativity, and debate. They are innovative and original visionaries who can generate and implement new ideas.
                ENFP: The Champion. They are creative, optimistic, and outgoing. They value freedom, inspiration, and potential. They are enthusiastic and charismatic champions who can motivate and persuade others.
                ISTP: The Craftsman. They are cool, calm, and collected. They value practicality, efficiency, and mastery. They are talented and independent craftsmen who can work with any tool.
                ISFP: The Composer. They are gentle, artistic, and adventurous. They value beauty, harmony, and spontaneity. They are flexible and expressive composers who can create and explore new things.
                INTP: The Thinker. They are logical, creative, and curious. They value theoretical, abstract, and complex. They are intellectual and original thinkers who can analyze and understand anything.
                INFP: The Idealist. They are poetic, kind, and altruistic. They value personal, moral, and spiritual. They are imaginative and passionate idealists who can envision and pursue a better world.
                """);

            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();

        }



    }
}




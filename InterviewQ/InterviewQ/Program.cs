using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace InterviewQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    "Adam", "Brad", "Bryan", "Danil",
                    "David", "Dinesh", "Eric", "Oriana",
                    "Jacob B.", "Jake","Tyler", "James P.", "Jared", "Joshua",
                      "Keshav", "Martin", "Michael", "Mykal",
                      "Omar", "Peter" , "Regina" , "Renata" , "Rob" ,
                        "Sheldon", "Tae", "Thomas", "Twokoko", "Zach"
                */

            Console.WriteLine("(After you're done with the questioning. Please press enter, type 'done' & press enter)." +
                " Welcome too todays interview.  Let us get started. Please tell us a little about yourself.");

            Console.ReadLine();

            Random rnd = new Random();

            /*
            string[] Question = { "What are your strengths? ","What are your weaknesses?" , "Who's your mentor?",
              "Who is someone you look up to? Why?" , "Name someone in your career who really made a difference",
            "Are you willing to travel?" , " How much are you willing to travel?" , " What's your availability? When can you start work? ",
            "How long do you expect to work for this company?" , "Why do you want to leave your current company?" ,
            "Why are you looking for a new job?", "Why are you leaving the military?", "Tell me about a time when you disagreed with your boss. How did you handle it?",
            "How would you handle a disagreement if your boss was wrong?" , " What do you expect from a supervisor?" ,
            "If I called your boss right now and asked him what is an area that you could improve on, what would he say?",
            "What are three positive things your last boss would say about you?", "What negative thing would your last boss say about you?",
              "Tell me about an accomplishment you are most proud of." ,
            "What's the most difficult decision you've made in the last two years and how did you come to that decision?" };
            */
            string[] Question = {"What are your strengths? ","What are your weaknesses?" , "Who's your mentor?",
              "Who is someone you look up to? Why?" , "Name someone in your career who really made a difference",
            "Are you willing to travel?" , " How much are you willing to travel?" , " What's your availability? When can you start work? ",
            "How long do you expect to work for this company?" , "Why do you want to leave your current company?" ,
            "Why are you looking for a new job?", "Why are you leaving the military?", "Tell me about a time when you disagreed with your boss. How did you handle it?",
            "How would you handle a disagreement if your boss was wrong?" , " What do you expect from a supervisor?" ,
            "If I called your boss right now and asked him what is an area that you could improve on, what would he say?",
            "What are three positive things your last boss would say about you?", "What negative thing would your last boss say about you?",
              "Tell me about an accomplishment you are most proud of." ,
            "What's the most difficult decision you've made in the last two years and how did you come to that decision?" };
            start:
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            // Generate random indexes for next name.

            int InterviewQ = rnd.Next(0, Question.Length);

            // Display the result.

            Console.WriteLine("{0}", Question[InterviewQ]);
            synth.Speak(""+ Question[InterviewQ]);

            Console.WriteLine();




            if (Console.ReadLine() == "done")
            {
                string message = "";
                message = "That's all the questions we have for today. Do you have anything to add or would like to ask any questions?";
                Console.Write(message);
                Console.ReadLine();

                message = "Thank you for your time. Please give us a week. If you don't hear from us, give us a call to follow up.";
                Console.Write(message);
                Console.ReadLine();
                Environment.Exit(0);
            }

            goto start;
        }

    }
}
           












        

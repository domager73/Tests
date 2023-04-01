using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public static class TxtxReader
    {
        public static List<Test> LoadFromFile(string fileName) 
        {
            List<Test> tests = new List<Test>();    

            StreamReader reader = new StreamReader(fileName);
            int examplesCount = int.Parse(reader.ReadLine());

            for (int i = 0; i < examplesCount; i++)
            {
                string question = reader.ReadLine();
                int countAnswers = int.Parse(reader.ReadLine());

                List<string> answers = new List<string>();

                for (int j = 0; j < countAnswers; j++)
                {
                    answers.Add(reader.ReadLine());
                }

                int numberRightAnswer = int.Parse(reader.ReadLine());


                tests.Add(new Test()
                {
                    Question = question,
                    Answers = answers,
                    CurrentAnswerIndex = numberRightAnswer
                });
            }

            reader.Close();

            return tests;
        }
    }
}

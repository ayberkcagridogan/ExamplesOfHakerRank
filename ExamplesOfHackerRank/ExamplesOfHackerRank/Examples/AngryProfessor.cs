using System;
namespace ExamplesOfHackerRank.Examples
{
    public class AngryProfessor
    {
        public string IsClassCancel(int minParticipantStudent , int[] studentsArrivalTime)
        {
            int studentArrivalOnTime = 0;

            for (int i = 0; i < studentsArrivalTime.Length; i++)
            {
                if(studentsArrivalTime[i] <= 0)
                {
                    studentArrivalOnTime++;
                }
            }

            if(minParticipantStudent > studentArrivalOnTime)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}

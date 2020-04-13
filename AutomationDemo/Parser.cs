using System;

namespace AutomationDemo
{
    public class Parser
    {

        public bool IsParseable(string input)
        {

            if (input.Trim().Length < 1)
                return false;

            return true;
        }

        public enum Response
        {
            Affirmative,
            Negative,
            Invalid
        }

        public Response ParseAnswer(string answer)
        {
            if (IsParseable(answer))
            {
                if (IsAffirmative(answer))
                    return Response.Affirmative;

                if (IsNegative(answer))
                    return Response.Negative;
            }

            return Response.Invalid;
        }

        public bool IsAffirmative(string input)
        {
            string cleaned_input = input.ToLower().Trim();

            if (cleaned_input.Equals("yes")
                || cleaned_input.Equals("y"))
                
                return true;

            return false;
        }

        public bool IsNegative(string input)
        {
            string cleaned_input = input.ToLower().Trim();

            if (cleaned_input.Equals("no")
                 || cleaned_input.Equals("n"))

                return true;

            return false;
        }
    }
}

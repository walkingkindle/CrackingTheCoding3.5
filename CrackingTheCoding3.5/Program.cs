namespace Solution
{
    internal class StackSurgeries
    {



        public Stack<int> sortStackSmallest(Stack<int> inputStack)
        {
            Stack<int> tmpStack = new Stack<int>();


            while(inputStack != null)
            {
                var temp = inputStack.Pop();

                while (tmpStack != null && tmpStack.Peek() < temp)
                {
                    inputStack.Push(tmpStack.Pop());
                }

                tmpStack.Push(temp);

            }

            return tmpStack;


        }
        




        }



    }


}
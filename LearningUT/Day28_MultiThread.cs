using System.Collections;
using System.Threading;
using NUnit.Framework;

namespace LearningUT
{
    class Day28_MultiThread
    {
        public Queue counterQue = new Queue();
        public bool status = false;     //var: correct = true. incorrect = false/
        public Day28_MultiThread()
        {
            Thread thread = new Thread(CompareNumbers);
            thread.Start();
        }

        public void CompareNumbers()
        {
            while (true)
            {
                if(counterQue.Count > 0)
                {
                    int[] numberArray = (int[])counterQue.Dequeue();
                    status = Equal2Times(numberArray[0], numberArray[1]);
                }
            }
        }

        public bool Equal2Times(int targetNumber, int testNumber)
        {
            if (targetNumber * 2 == testNumber)
                return true;
            else
                return false;
        }



        
    }

    class Day28_MultiThread_test
    {
        [TestCase(2, 4)]
        public void Equal2Times_PutNumber_ReturnTrue(int targetNO, int testNO)
        {
            Day28_MultiThread testObj = new Day28_MultiThread();

            testObj.counterQue.Enqueue(new int[2] { targetNO, testNO });
            //bool result = testObj.Equal2Times(targetNO, testNO);

            bool result = testObj.status;

            Assert.AreEqual(result, true);      //will be error

        }
    }

}

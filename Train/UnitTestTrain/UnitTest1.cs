using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTrain
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DistanceBird()
        {
            float distance = CalculateDistance(20, 80);
            Assert.AreEqual(40, distance);
        }
        
        float CalculateDistance(float trainSpeed, float trainDistance)
        {
            float birdSpeed = 2 * trainSpeed;
            float birdTime = trainDistance / birdSpeed - ((trainDistance / 4)/trainSpeed);
            float birdDistance = birdSpeed * birdTime; 
            return birdDistance;
        }
    }
}

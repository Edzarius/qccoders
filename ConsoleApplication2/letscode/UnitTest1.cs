using System;
using Xunit;

namespace letscode
{
    public class UnitTest1
    {
        #region Public Methods
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(1, 2);
        }
        #endregion Public Methods

    }
}

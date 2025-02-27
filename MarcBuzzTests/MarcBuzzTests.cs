using Xunit;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Xunit.Assert;
using Microsoft.Testing.Platform.MSBuild;

namespace ClassLibrary1.Tests
{
    public class MarcBuzzTests
    {

        [InlineData(1)]
        [InlineData(2)]
        [InlineData(22)]
        [InlineData(88)]
        [InlineData(62)]
        [Theory]
        public void ConvertIntIntegerReturn(int i)
        {
            string expected = i.ToString();

            string actual = MarcBuzz.ConvertInt(i);

            Assert.Equal(expected, actual);
        }

        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(18)]
        [InlineData(33)]
        [Theory]
        public void ConvertIntThreesReturn(int i)
        {
            string expected = "Marc";

            string actual = MarcBuzz.ConvertInt(i);

            Assert.Equal(expected, actual);
        }

        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        [InlineData(55)]
        [Theory]
        public void ConvertIntFivesReturn(int i)
        {
            string expected = "Week";

            string actual = MarcBuzz.ConvertInt(i);

            Assert.Equal(expected, actual);
        }

        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        [InlineData(90)]
        [InlineData(45)]
        [Theory]
        public void ConvertIntFivesandThreesReturn(int i)
        {
            string expected = "Marc Week";

            string actual = MarcBuzz.ConvertInt(i);

            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void RunMarcBuzzTest()
        {
            string buzz = MarcBuzz.RunMarcBuzz();
            
            var lines = buzz.Trim().Split(Environment.NewLine);

            Assert.Equal(100, lines.Length);
            Assert.Equal("1", lines[0]);
            Assert.Equal("2", lines[1]);
            Assert.Equal("Marc", lines[2]);
            Assert.Equal("Week", lines[4]);
            Assert.Equal("Week", lines[99]);

        }
    }
}
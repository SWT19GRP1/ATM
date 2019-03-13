using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ATM.Interfaces;
using NSubstitute;
using NUnit.Framework;

namespace ATM.Test.Unit
{
    [TestFixture]
    class TestOutput
    {


        private IVehicleFormatter _format;
        private IOutput _uut;
        private string _path;
        private List<IVehicle> _vehicle;
        #region setup
        [SetUp]
        public void Setup()
        {
            _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\LoggedAirplanes.txt";
            _format = Substitute.For<IVehicleFormatter>();
            _uut = new LogOutput(_format);
        }
        #endregion
        #region FileOutputTests
        [Test]
        public void CreateANewFileWhenNoFileIsPresent()
        {
            if(File.Exists(_path))
                File.Delete(_path);
            _uut.LogVehicleData(_vehicle);
            Assert.That(File.Exists(_path));
        }

        [Test]
        public void AppendAFileWhenFileIsPresent()
        {

        }
        #endregion

    }
}

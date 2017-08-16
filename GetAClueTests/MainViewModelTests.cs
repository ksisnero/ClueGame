using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetAClue;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using GetAClue.ViewModels;

namespace GetAClueTests
{
    [TestClass()]
    public class MainViewModelTests
    {
        public MainViewModel MainViewModel = new MainViewModel();

        [TestMethod()]
        public void StartGameTest()
        {
            MainViewModel mainViewModel = new MainViewModel();
            var booleanToVisibilityConverter = new BooleanToVisibilityConverter();

            Assert.AreEqual(true, mainViewModel.ChooseRoomOptionVisible);
            Assert.AreEqual(false, mainViewModel.ChooseWeaponOptionVisible);
            Assert.AreEqual(false, mainViewModel.ChooseSuspectOptionVisible);

            //Does true/false boolean equal to appropriate visibilty
            Assert.IsTrue(booleanToVisibilityConverter.Convert(true, typeof(Visibility), null, new CultureInfo("en-US"))
                .Equals(Visibility.Visible));
            Assert.IsTrue(booleanToVisibilityConverter
                .Convert(false, typeof(Visibility), null, new CultureInfo("en-US"))
                .Equals(Visibility.Collapsed));
        }
    }
}
using CSharp.Assignments.Tests.Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Tests
{
    public class BinarySearchTests
    {
        private dynamic _object;
        [SetUp]
        public void SetUp()
        {
            _object = new BinarySearch();
        }
        [Test]
        [Category("Easy")]
        [Timeout(500)]
        public void Find()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            Assert.AreEqual(0, _object.Find(new[] { 1, 5, 7, 10, 20, 100 }, 1));
            Assert.AreEqual(5, _object.Find(new[] { 1, 5, 7, 10, 20, 100 }, 100));
            Assert.AreEqual(2, _object.Find(new[] { 1, 5, 7, 10, 20, 100 }, 7));
            Assert.AreEqual(3, _object.Find(new[] { 1, 5, 7, 10, 20, 100 }, 10));
            Assert.AreEqual(-1, _object.Find(new[] { 1, 5, 7, 10, 20, 100 }, -1));
            Assert.AreEqual(-1, _object.Find(new[] { 1, 5, 7, 10, 20, 100 }, 200));
            Assert.AreEqual(-1, _object.Find(new[] { 1, 5, 7, 10, 20, 100 }, 6));
            Assert.AreEqual(-1, _object.Find(new[] { 1, 5, 7, 10, 20, 100 }, 8));

            int[] a = { 0, 6, 8, 9, 10, 11, 18, 19, 24, 35, 38, 49, 60, 71, 77, 83, 85, 88, 90, 92, 93, 95 };
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(i, _object.Find(a, a[i]));
            }
            a = Generate(1000000);
            Assert.AreEqual(0, _object.Find(a, 1));
            Assert.AreEqual(100000, _object.Find(a, 4933551));
            Assert.AreEqual(200000, _object.Find(a, 9866826));
            Assert.AreEqual(300000, _object.Find(a, 14800001));
            Assert.AreEqual(400000, _object.Find(a, 19733551));
            Assert.AreEqual(500000, _object.Find(a, 24666826));
            Assert.AreEqual(600000, _object.Find(a, 29600001));
            Assert.AreEqual(700000, _object.Find(a, 34533551));
            Assert.AreEqual(800000, _object.Find(a, 39466826));
            Assert.AreEqual(900000, _object.Find(a, 44400001));
            Assert.AreEqual(999999, _object.Find(a, 49333475));
#if !DEBUG
        });
#endif
        }

        [Test]
        [Category("Easy")]
        [Timeout(500)]
        public void Search()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            string[] wordlist = { "a", "brown", "dog", "fox", "jumps", "lazy", "over", "quick", "the" };
            Assert.AreEqual(0, _object.Search(wordlist, "a"));
            Assert.AreEqual(1, _object.Search(wordlist, "brown"));
            Assert.AreEqual(2, _object.Search(wordlist, "dog"));
            Assert.AreEqual(3, _object.Search(wordlist, "fox"));
            Assert.AreEqual(4, _object.Search(wordlist, "jumps"));
            Assert.AreEqual(5, _object.Search(wordlist, "lazy"));
            Assert.AreEqual(6, _object.Search(wordlist, "over"));
            Assert.AreEqual(7, _object.Search(wordlist, "quick"));
            Assert.AreEqual(8, _object.Search(wordlist, "the"));
            Assert.AreEqual(-1, _object.Search(wordlist, "Brown"));
            Assert.AreEqual(-1, _object.Search(wordlist, " fox"));
            Assert.AreEqual(-1, _object.Search(wordlist, "C#"));

            wordlist = Utils.WordList; // gets a list of words

            Assert.AreEqual(0, _object.Search(wordlist, "aardvark"));
            Assert.AreEqual(1000, _object.Search(wordlist, "affront"));
            Assert.AreEqual(2000, _object.Search(wordlist, "anomic"));
            Assert.AreEqual(3000, _object.Search(wordlist, "astronomical"));
            Assert.AreEqual(4000, _object.Search(wordlist, "basque"));
            Assert.AreEqual(5000, _object.Search(wordlist, "blamelessly"));
            Assert.AreEqual(6000, _object.Search(wordlist, "brewer"));
            Assert.AreEqual(7000, _object.Search(wordlist, "canon"));
            Assert.AreEqual(8000, _object.Search(wordlist, "cheating"));
            Assert.AreEqual(9000, _object.Search(wordlist, "cobbles"));
            Assert.AreEqual(10000, _object.Search(wordlist, "confidants"));
            Assert.AreEqual(11000, _object.Search(wordlist, "corsica"));
            Assert.AreEqual(12000, _object.Search(wordlist, "curls"));
            Assert.AreEqual(13000, _object.Search(wordlist, "deists"));
            Assert.AreEqual(14000, _object.Search(wordlist, "diffidently"));
            Assert.AreEqual(15000, _object.Search(wordlist, "divergent"));
            Assert.AreEqual(16000, _object.Search(wordlist, "earpieces"));
            Assert.AreEqual(17000, _object.Search(wordlist, "enfranchiser"));
            Assert.AreEqual(18000, _object.Search(wordlist, "excommunicate"));
            Assert.AreEqual(19000, _object.Search(wordlist, "feebly"));
            Assert.AreEqual(20000, _object.Search(wordlist, "foamier"));
            Assert.AreEqual(21000, _object.Search(wordlist, "funk"));
            Assert.AreEqual(22000, _object.Search(wordlist, "gnu"));
            Assert.AreEqual(23000, _object.Search(wordlist, "haggler"));
            Assert.AreEqual(24000, _object.Search(wordlist, "highlander"));
            Assert.AreEqual(25000, _object.Search(wordlist, "icon"));
            Assert.AreEqual(26000, _object.Search(wordlist, "indigenous"));
            Assert.AreEqual(27000, _object.Search(wordlist, "interlock"));
            Assert.AreEqual(28000, _object.Search(wordlist, "judo"));
            Assert.AreEqual(29000, _object.Search(wordlist, "leaves"));
            Assert.AreEqual(30000, _object.Search(wordlist, "loquacity"));
            Assert.AreEqual(31000, _object.Search(wordlist, "masterpieces"));
            Assert.AreEqual(32000, _object.Search(wordlist, "miraculously"));
            Assert.AreEqual(33000, _object.Search(wordlist, "multilingual"));
            Assert.AreEqual(34000, _object.Search(wordlist, "notification"));
            Assert.AreEqual(35000, _object.Search(wordlist, "outbid"));
            Assert.AreEqual(36000, _object.Search(wordlist, "parenthood"));
            Assert.AreEqual(37000, _object.Search(wordlist, "petrified"));
            Assert.AreEqual(38000, _object.Search(wordlist, "politeness"));
            Assert.AreEqual(39000, _object.Search(wordlist, "primetime"));
            Assert.AreEqual(40000, _object.Search(wordlist, "purplish"));
            Assert.AreEqual(41000, _object.Search(wordlist, "rearranges"));
            Assert.AreEqual(42000, _object.Search(wordlist, "relate"));
            Assert.AreEqual(43000, _object.Search(wordlist, "retracts"));
            Assert.AreEqual(44000, _object.Search(wordlist, "rushhour"));
            Assert.AreEqual(45000, _object.Search(wordlist, "seamanship"));
            Assert.AreEqual(46000, _object.Search(wordlist, "shorelines"));
            Assert.AreEqual(47000, _object.Search(wordlist, "sluggishly"));
            Assert.AreEqual(48000, _object.Search(wordlist, "spender"));
            Assert.AreEqual(49000, _object.Search(wordlist, "stirring"));
            Assert.AreEqual(50000, _object.Search(wordlist, "sunk"));
            Assert.AreEqual(51000, _object.Search(wordlist, "tasking"));
            Assert.AreEqual(52000, _object.Search(wordlist, "tilted"));
            Assert.AreEqual(53000, _object.Search(wordlist, "trickiest"));
            Assert.AreEqual(54000, _object.Search(wordlist, "uncrowned"));
            Assert.AreEqual(55000, _object.Search(wordlist, "unselfishly"));
            Assert.AreEqual(56000, _object.Search(wordlist, "view"));
            Assert.AreEqual(57000, _object.Search(wordlist, "whack"));
            Assert.AreEqual(58000, _object.Search(wordlist, "your"));
            Assert.AreEqual(58105, _object.Search(wordlist, "zulus"));
#if !DEBUG
    });
#endif
        }

        [Test]
        [Category("Medium")]
        [Timeout(500)]
        public void CubeRoot()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            Assert.AreEqual(0.0, _object.CubeRoot(0.0), 1E-10);
            Assert.AreEqual(1.0, _object.CubeRoot(1.0), 1E-10);
            Assert.AreEqual(2.0, _object.CubeRoot(8.0), 1E-10);
            Assert.AreEqual(3.0, _object.CubeRoot(27.0), 1E-10);
            Assert.AreEqual(4.0, _object.CubeRoot(64.0), 1E-10);
            Assert.AreEqual(5.0, _object.CubeRoot(125.0), 1E-10);
            Assert.AreEqual(6.0, _object.CubeRoot(216.0), 1E-10);
            Assert.AreEqual(7.0, _object.CubeRoot(343.0), 1E-10);
            Assert.AreEqual(8.0, _object.CubeRoot(512.0), 1E-10);
            Assert.AreEqual(9.0, _object.CubeRoot(729.0), 1E-10);
            Assert.AreEqual(10.0, _object.CubeRoot(1000.0), 1E-10);
            Assert.AreEqual(11.0, _object.CubeRoot(1331.0), 1E-10);
            Assert.AreEqual(12.0, _object.CubeRoot(1728.0), 1E-10);
            Assert.AreEqual(13.0, _object.CubeRoot(2197.0), 1E-10);
            Assert.AreEqual(14.0, _object.CubeRoot(2744.0), 1E-10);
            Assert.AreEqual(15.0, _object.CubeRoot(3375.0), 1E-10);
            Assert.AreEqual(16.0, _object.CubeRoot(4096.0), 1E-10);
            Assert.AreEqual(17.0, _object.CubeRoot(4913.0), 1E-10);
            Assert.AreEqual(18.0, _object.CubeRoot(5832.0), 1E-10);
            Assert.AreEqual(19.0, _object.CubeRoot(6859.0), 1E-10);
            Assert.AreEqual(20.0, _object.CubeRoot(8000.0), 1E-10);
            Assert.AreEqual(21.0, _object.CubeRoot(9261.0), 1E-10);
            Assert.AreEqual(22.0, _object.CubeRoot(10648.0), 1E-10);
            Assert.AreEqual(23.0, _object.CubeRoot(12167.0), 1E-10);
            Assert.AreEqual(24.0, _object.CubeRoot(13824.0), 1E-10);
            Assert.AreEqual(25.0, _object.CubeRoot(15625.0), 1E-10);
            Assert.AreEqual(26.0, _object.CubeRoot(17576.0), 1E-10);
            Assert.AreEqual(27.0, _object.CubeRoot(19683.0), 1E-10);
            Assert.AreEqual(28.0, _object.CubeRoot(21952.0), 1E-10);
            Assert.AreEqual(29.0, _object.CubeRoot(24389.0), 1E-10);
            Assert.AreEqual(30.0, _object.CubeRoot(27000.0), 1E-10);
            Assert.AreEqual(31.0, _object.CubeRoot(29791.0), 1E-10);
            Assert.AreEqual(32.0, _object.CubeRoot(32768.0), 1E-10);
            Assert.AreEqual(33.0, _object.CubeRoot(35937.0), 1E-10);
            Assert.AreEqual(34.0, _object.CubeRoot(39304.0), 1E-10);
            Assert.AreEqual(35.0, _object.CubeRoot(42875.0), 1E-10);
            Assert.AreEqual(36.0, _object.CubeRoot(46656.0), 1E-10);
            Assert.AreEqual(37.0, _object.CubeRoot(50653.0), 1E-10);
            Assert.AreEqual(38.0, _object.CubeRoot(54872.0), 1E-10);
            Assert.AreEqual(39.0, _object.CubeRoot(59319.0), 1E-10);
            Assert.AreEqual(40.0, _object.CubeRoot(64000.0), 1E-10);
            Assert.AreEqual(41.0, _object.CubeRoot(68921.0), 1E-10);
            Assert.AreEqual(42.0, _object.CubeRoot(74088.0), 1E-10);
            Assert.AreEqual(43.0, _object.CubeRoot(79507.0), 1E-10);
            Assert.AreEqual(44.0, _object.CubeRoot(85184.0), 1E-10);
            Assert.AreEqual(45.0, _object.CubeRoot(91125.0), 1E-10);
            Assert.AreEqual(46.0, _object.CubeRoot(97336.0), 1E-10);
            Assert.AreEqual(47.0, _object.CubeRoot(103823.0), 1E-10);
            Assert.AreEqual(48.0, _object.CubeRoot(110592.0), 1E-10);
            Assert.AreEqual(49.0, _object.CubeRoot(117649.0), 1E-10);
            Assert.AreEqual(50.0, _object.CubeRoot(125000.0), 1E-10);
            Assert.AreEqual(1.44224957030741, _object.CubeRoot(3), 1E-10);
            Assert.AreEqual(1.5874010519682, _object.CubeRoot(4), 1E-10);
            Assert.AreEqual(2.0800838230519, _object.CubeRoot(9), 1E-10);
            Assert.AreEqual(3.97905720789639, _object.CubeRoot(63), 1E-10);
            Assert.AreEqual(4.12128529980856, _object.CubeRoot(70), 1E-10);
            Assert.AreEqual(2.75892417638112, _object.CubeRoot(21), 1E-10);
            Assert.AreEqual(3.53034833532606, _object.CubeRoot(44), 1E-10);
            Assert.AreEqual(3.70842976926619, _object.CubeRoot(51), 1E-10);
            Assert.AreEqual(8.87904001742601, _object.CubeRoot(700), 1E-10);
            Assert.AreEqual(8.75903827977578, _object.CubeRoot(672), 1E-10);
            Assert.AreEqual(7.28736163112184, _object.CubeRoot(387), 1E-10);
            Assert.AreEqual(6.36609676041689, _object.CubeRoot(258), 1E-10);
            Assert.AreEqual(9.10172651699613, _object.CubeRoot(754), 1E-10);
            Assert.AreEqual(12.5295301825296, _object.CubeRoot(1967), 1E-10);
            Assert.AreEqual(21.5299744164666, _object.CubeRoot(9980), 1E-10);
            Assert.AreEqual(14.0440787602032, _object.CubeRoot(2770), 1E-10);
            Assert.AreEqual(14.4688192435891, _object.CubeRoot(3029), 1E-10);
            Assert.AreEqual(17.7496197762896, _object.CubeRoot(5592), 1E-10);
            Assert.AreEqual(22.3624530427029, _object.CubeRoot(11183), 1E-10);
            Assert.AreEqual(46.2601828078135, _object.CubeRoot(98997), 1E-10);
            Assert.AreEqual(44.5326108643317, _object.CubeRoot(88315), 1E-10);
            Assert.AreEqual(38.321828095196, _object.CubeRoot(56278), 1E-10);
            Assert.AreEqual(40.5545675064915, _object.CubeRoot(66699), 1E-10);
            Assert.AreEqual(68.673243261557, _object.CubeRoot(323864), 1E-10);
            Assert.AreEqual(69.307803614317, _object.CubeRoot(332925), 1E-10);
            Assert.AreEqual(96.7464950311258, _object.CubeRoot(905536), 1E-10);
            Assert.AreEqual(74.0919237477907, _object.CubeRoot(406736), 1E-10);
            Assert.AreEqual(76.6463798455538, _object.CubeRoot(450272), 1E-10);
            Assert.AreEqual(118.942678887788, _object.CubeRoot(1682725), 1E-10);
            Assert.AreEqual(207.865119963143, _object.CubeRoot(8981417), 1E-10);
            Assert.AreEqual(194.865109428943, _object.CubeRoot(7399498), 1E-10);
            Assert.AreEqual(157.588162616801, _object.CubeRoot(3913549), 1E-10);
            Assert.AreEqual(206.592928370278, _object.CubeRoot(8817518), 1E-10);
            Assert.AreEqual(396.787516865653, _object.CubeRoot(62470359), 1E-10);
            Assert.AreEqual(303.585025036109, _object.CubeRoot(27979570), 1E-10);
            Assert.AreEqual(398.064468147476, _object.CubeRoot(63075433), 1E-10);
            Assert.AreEqual(440.344081751878, _object.CubeRoot(85383999), 1E-10);
            Assert.AreEqual(416.255919559184, _object.CubeRoot(72124243), 1E-10);
            Assert.AreEqual(850.940811577799, _object.CubeRoot(616166467), 1E-10);
            Assert.AreEqual(967.913655840338, _object.CubeRoot(906796534), 1E-10);
            Assert.AreEqual(806.150655708166, _object.CubeRoot(523900285), 1E-10);
            Assert.AreEqual(972.026367922044, _object.CubeRoot(918404786), 1E-10);
            Assert.AreEqual(847.278543030918, _object.CubeRoot(608245108), 1E-10);
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Medium")]
        [Timeout(5000)]
        public void CountNumbers()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            int[] array = { 1, 1, 1, 2, 3, 3, 5, 5, 8, 8, 8, 9, 9, 10 };
            int[] expected = { 0, 3, 1, 2, 0, 2, 0, 0, 3, 2, 1 };
            Assert.AreEqual(expected, _object.CountNumbers(array));

            array = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            expected = new[] { 0, 10 };
            Assert.AreEqual(expected, _object.CountNumbers(array));

            // longer test cases
            expected = new[] { 0, 0, 0, 20000000 };
            array = Enumerable.Repeat(3, 20000000).ToArray();
            Assert.AreEqual(expected, _object.CountNumbers(array));

            expected = new int[] { 3837051, 0, 8536229, 0, 0, 7815620, 0, 4119222, 0, 0, 5175798, 0, 7426063, 8598188, 0, 0, 1522764, 0, 0, 0, 2642321 };
            int i = 0;
            array = (from e in expected
                     from a in Enumerable.Repeat(i++, e)
                     select a).ToArray();
            Assert.AreEqual(expected, _object.CountNumbers(array));

            CountNumbersData(out array, out expected);
            Assert.AreEqual(expected, _object.CountNumbers(array));
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Medium")]
        [Timeout(5000)]
        public void AppearOnce()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            int[] array = { 1, 3, 3, 4, 4, 5, 5, 7, 7, 8, 8 };
            Assert.AreEqual(1, _object.AppearOnce(array));
            array = new[] { 1, 1, 3, 4, 4, 5, 5, 7, 7, 8, 8 };
            Assert.AreEqual(3, _object.AppearOnce(array));
            array = new[] { 1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8 };
            Assert.AreEqual(4, _object.AppearOnce(array));
            array = new[] { 1, 1, 3, 3, 4, 4, 5, 7, 7, 8, 8 };
            Assert.AreEqual(5, _object.AppearOnce(array));
            array = new[] { 1, 1, 3, 3, 4, 4, 5, 5, 7, 8, 8 };
            Assert.AreEqual(7, _object.AppearOnce(array));
            array = new[] { 1, 1, 3, 3, 4, 4, 5, 5, 7, 7, 8 };
            Assert.AreEqual(8, _object.AppearOnce(array));

            // Longer test cases
            int length = 5000000;
            for (int expected = 0; expected <= length; expected += 100000)
            {
                array = AppearOnceData(length, expected);
                Assert.AreEqual(expected, _object.AppearOnce(array));
            }
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Medium")]
        [Timeout(5000)]
        public void ExtraElement()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            int[] first = { 2, 4, 6, 8, 9, 10, 12 };
            Assert.AreEqual(0, _object.ExtraElement(first, new[] { 4, 6, 8, 9, 10, 12 }));
            Assert.AreEqual(1, _object.ExtraElement(first, new[] { 2, 6, 8, 9, 10, 12 }));
            Assert.AreEqual(2, _object.ExtraElement(first, new[] { 2, 4, 8, 9, 10, 12 }));
            Assert.AreEqual(3, _object.ExtraElement(first, new[] { 2, 4, 6, 9, 10, 12 }));
            Assert.AreEqual(4, _object.ExtraElement(first, new[] { 2, 4, 6, 8, 10, 12 }));
            Assert.AreEqual(5, _object.ExtraElement(first, new[] { 2, 4, 6, 8, 9, 12 }));
            Assert.AreEqual(6, _object.ExtraElement(first, new[] { 2, 4, 6, 8, 9, 10 }));

            first = new[] { 3, 5, 7, 9, 11, 13 };
            Assert.AreEqual(0, _object.ExtraElement(first, new[] { 5, 7, 9, 11, 13 }));
            Assert.AreEqual(1, _object.ExtraElement(first, new[] { 3, 7, 9, 11, 13 }));
            Assert.AreEqual(2, _object.ExtraElement(first, new[] { 3, 5, 9, 11, 13 }));
            Assert.AreEqual(3, _object.ExtraElement(first, new[] { 3, 5, 7, 11, 13 }));
            Assert.AreEqual(4, _object.ExtraElement(first, new[] { 3, 5, 7, 9, 13 }));
            Assert.AreEqual(5, _object.ExtraElement(first, new[] { 3, 5, 7, 9, 11 }));

            // longer runs
            first = Enumerable.Range(0, 10000001).ToArray();
            for (int expected = 0; expected <= 10000000; expected += 1000000)
            {
                int[] second = first.Where(value => value != expected).ToArray();
                Assert.AreEqual(expected, _object.ExtraElement(first, second));
            }
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Medium")]
        [Timeout(5000)]
        public void RepeatingElement()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            Assert.AreEqual(1, _object.RepeatingElement(new[] { 1, 1, 2, 3, 4 }));
            Assert.AreEqual(2, _object.RepeatingElement(new[] { 1, 2, 2, 3, 4 }));
            Assert.AreEqual(3, _object.RepeatingElement(new[] { 1, 2, 3, 3, 4 }));
            Assert.AreEqual(4, _object.RepeatingElement(new[] { 1, 2, 3, 4, 4 }));

            Assert.AreEqual(1, _object.RepeatingElement(new[] { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(2, _object.RepeatingElement(new[] { 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(3, _object.RepeatingElement(new[] { 1, 2, 3, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(4, _object.RepeatingElement(new[] { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(5, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(6, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(7, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(8, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(9, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(10, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(11, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(12, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 12, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(13, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(14, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(15, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(16, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(17, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 17, 18, 19, 20 }));
            Assert.AreEqual(18, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 18, 19, 20 }));
            Assert.AreEqual(19, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 19, 20 }));
            Assert.AreEqual(20, _object.RepeatingElement(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 20 }));

            // longer runs
            const int length = 5000000;
            for (int i = 0; i <= length; i += 100000)
            {
                int expected = i == 0 ? 1 : i;
                int[] array = Enumerable.Range(1, length + 1).Select(o => o > expected ? o - 1 : o).ToArray();
            }
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Medium")]
        [Timeout(500)]
        public void Floor()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            int[] array = { 1, 2, 8, 10, 10, 12, 19 };
            Assert.AreEqual(2, _object.Floor(array, 5));
            Assert.AreEqual(19, _object.Floor(array, 19));
            Assert.AreEqual(1, _object.Floor(array, 0));

            // longer runs
            array = Generate(5000000);
            Assert.AreEqual(1, _object.Floor(array, -10));
            Assert.AreEqual(1, _object.Floor(array, 0));
            Assert.AreEqual(1, _object.Floor(array, 1));
            Assert.AreEqual(1, _object.Floor(array, 2));
            Assert.AreEqual(3, _object.Floor(array, 4));
            Assert.AreEqual(6, _object.Floor(array, 6));
            Assert.AreEqual(6, _object.Floor(array, 8));
            Assert.AreEqual(6, _object.Floor(array, 10));
            Assert.AreEqual(6, _object.Floor(array, 10));
            Assert.AreEqual(19, _object.Floor(array, 20));
            Assert.AreEqual(32, _object.Floor(array, 40));
            Assert.AreEqual(53, _object.Floor(array, 60));
            Assert.AreEqual(53, _object.Floor(array, 80));
            Assert.AreEqual(87, _object.Floor(array, 100));
            Assert.AreEqual(87, _object.Floor(array, 100));
            Assert.AreEqual(142, _object.Floor(array, 200));
            Assert.AreEqual(395, _object.Floor(array, 400));
            Assert.AreEqual(579, _object.Floor(array, 600));
            Assert.AreEqual(744, _object.Floor(array, 800));
            Assert.AreEqual(991, _object.Floor(array, 1000));
            Assert.AreEqual(991, _object.Floor(array, 1000));
            Assert.AreEqual(1968, _object.Floor(array, 2000));
            Assert.AreEqual(3995, _object.Floor(array, 4000));
            Assert.AreEqual(5980, _object.Floor(array, 6000));
            Assert.AreEqual(7959, _object.Floor(array, 8000));
            Assert.AreEqual(9975, _object.Floor(array, 10000));
            Assert.AreEqual(9975, _object.Floor(array, 10000));
            Assert.AreEqual(19951, _object.Floor(array, 20000));
            Assert.AreEqual(39967, _object.Floor(array, 40000));
            Assert.AreEqual(59944, _object.Floor(array, 60000));
            Assert.AreEqual(79980, _object.Floor(array, 80000));
            Assert.AreEqual(99934, _object.Floor(array, 100000));
            Assert.AreEqual(99934, _object.Floor(array, 100000));
            Assert.AreEqual(199945, _object.Floor(array, 200000));
            Assert.AreEqual(399995, _object.Floor(array, 400000));
            Assert.AreEqual(599959, _object.Floor(array, 600000));
            Assert.AreEqual(799944, _object.Floor(array, 800000));
            Assert.AreEqual(999951, _object.Floor(array, 1000000));
            Assert.AreEqual(999951, _object.Floor(array, 1000000));
            Assert.AreEqual(1999968, _object.Floor(array, 2000000));
            Assert.AreEqual(3999995, _object.Floor(array, 4000000));
            Assert.AreEqual(5999980, _object.Floor(array, 6000000));
            Assert.AreEqual(7999959, _object.Floor(array, 8000000));
            Assert.AreEqual(9999975, _object.Floor(array, 10000000));
            Assert.AreEqual(9999975, _object.Floor(array, 10000000));
            Assert.AreEqual(19999951, _object.Floor(array, 20000000));
            Assert.AreEqual(39999967, _object.Floor(array, 40000000));
            Assert.AreEqual(59999944, _object.Floor(array, 60000000));
            Assert.AreEqual(79999980, _object.Floor(array, 80000000));
            Assert.AreEqual(99999934, _object.Floor(array, 100000000));

#if !DEBUG
});
#endif
        }

        private int[] Generate(int n)
        {
            int a = 0;
            int b = 1;
            int t;
            int[] f = new int[n];
            for (int i = 0, j = 0; i < n; i++)
            {
                t = b % 100;
                b = (a + b) % 100;
                a = t;
                f[i] = j += b;
            }
            return f;
        }

        public void CountNumbersData(out int[] array, out int[] expected)
        {
            expected = new int[2000] { 17010, 0, 0, 33, 0, 0, 0, 9835, 0, 3730, 0, 21, 17190, 0, 30841, 0, 0, 0, 461844, 82, 0, 0, 74358, 0, 0, 0, 2240, 0, 3271, 1006, 0, 0, 0, 74937, 30879, 0, 129, 0, 0, 0, 63908, 337, 0, 0, 60, 2325, 0, 34, 162, 0, 24, 0, 0, 0, 41973, 0, 594, 0, 13426, 0, 0, 0, 9818, 78921, 45556, 0, 0, 35812, 0, 0, 0, 2, 0, 946, 64, 0, 0, 182420, 0, 0, 0, 2, 8858, 20, 0, 136, 0, 0, 0, 55, 0, 0, 0, 347267, 31762, 16, 8, 0, 357, 0, 0, 0, 846, 0, 0, 0, 518, 0, 0, 0, 120858, 3444, 0, 0, 0, 1084, 647, 0, 25, 0, 0, 0, 406, 0, 0, 0, 1086, 371814, 0, 0, 129265, 0, 0, 0, 4219, 143, 0, 86991, 102847, 0, 0, 205, 0, 0, 0, 12, 0, 0, 0, 45623, 0, 38, 0, 260985, 0, 0, 0, 38956, 0, 0, 0, 1772, 0, 0, 0, 570136, 239802, 0, 176988, 11130, 61, 0, 154, 0, 0, 0, 40395, 0, 0, 11036, 0, 0, 0, 62144, 13193, 652, 0, 0, 56391, 0, 0, 105167, 0, 19077, 8, 0, 914, 0, 691, 0, 0, 0, 124412, 0, 0, 122, 0, 15, 0, 0, 0, 25, 0, 0, 0, 13, 568, 7017, 0, 0, 0, 3236, 3395, 327, 0, 0, 8074, 0, 0, 0, 23, 0, 0, 182869, 0, 0, 0, 1021, 0, 0, 0, 179, 0, 0, 37, 1225, 0, 958, 11, 0, 0, 7896, 0, 0, 265, 0, 0, 360, 0, 0, 0, 8, 0, 0, 362, 0, 0, 0, 13, 0, 266436, 0, 0, 693, 0, 0, 619874, 0, 0, 206, 0, 0, 638, 0, 7, 0, 0, 0, 64, 0, 0, 0, 304, 0, 0, 0, 73251, 0, 0, 0, 262, 0, 494, 0, 9370, 0, 0, 0, 12, 0, 225960, 0, 0, 0, 10, 0, 218, 0, 0, 0, 214, 33, 3423, 0, 3351, 0, 0, 53112, 0, 0, 0, 36, 0, 0, 0, 66, 0, 0, 0, 2420, 1767, 0, 0, 0, 9, 0, 0, 0, 20802, 37413, 0, 0, 0, 61, 0, 87, 0, 0, 1539, 0, 0, 5977, 0, 0, 3, 150, 0, 0, 0, 35, 0, 51, 0, 0, 317, 0, 2167, 550, 0, 0, 575834, 0, 0, 1142, 0, 0, 80, 0, 2241, 11, 36925, 0, 1090, 705, 0, 0, 630998, 0, 0, 0, 19, 0, 0, 886, 0, 6, 4663, 0, 120, 0, 0, 0, 490855, 0, 0, 585, 0, 918, 0, 159799, 1256, 0, 0, 0, 89977, 0, 0, 0, 65179, 20314, 0, 0, 8137, 0, 0, 0, 105875, 0, 5, 203, 0, 327492, 0, 0, 0, 446, 0, 203, 0, 419, 0, 0, 900, 0, 267, 0, 29122, 0, 0, 65, 698, 0, 551847, 0, 0, 0, 78605, 0, 0, 0, 4648, 22, 0, 0, 17644, 0, 128, 0, 351, 0, 0, 28, 0, 0, 0, 22160, 0, 8598, 0, 0, 76148, 66030, 0, 0, 0, 2618, 0, 73194, 0, 0, 0, 202, 0, 0, 0, 6743, 0, 0, 0, 562, 0, 1067, 0, 0, 0, 143767, 175040, 0, 0, 4712, 501, 0, 0, 2256, 16340, 0, 0, 0, 11, 0, 0, 62769, 0, 647772, 0, 425, 0, 0, 0, 25, 0, 0, 0, 8, 0, 12221, 0, 28662, 0, 0, 0, 38495, 0, 0, 0, 98, 240716, 5731, 0, 0, 192, 40161, 35, 0, 0, 12, 32189, 0, 0, 0, 5096, 3179, 4026, 0, 0, 0, 3818, 0, 0, 0, 89, 0, 0, 101850, 0, 0, 130, 0, 0, 0, 607, 0, 0, 23, 397, 0, 0, 87297, 0, 0, 0, 252, 0, 0, 162012, 0, 969, 0, 0, 0, 154, 0, 330, 0, 0, 13, 0, 0, 406, 0, 0, 94356, 11852, 0, 0, 15, 0, 0, 29, 145272, 16610, 0, 0, 2116, 2, 0, 0, 0, 428, 0, 0, 1506, 0, 10, 0, 0, 0, 310, 6032, 0, 3729, 0, 359, 0, 12, 850, 36, 0, 0, 0, 2358, 129, 0, 0, 0, 49, 28, 340, 0, 10, 0, 0, 0, 69, 0, 0, 12754, 0, 0, 0, 230, 105, 0, 0, 0, 38, 0, 0, 36, 0, 0, 298512, 0, 0, 0, 2468, 0, 0, 94, 113, 18176, 2406, 262, 0, 603, 135682, 0, 16, 6637, 0, 0, 68209, 0, 0, 0, 203885, 0, 36235, 0, 7421, 0, 0, 447127, 0, 0, 213637, 4329, 51, 0, 119942, 0, 0, 34, 417386, 0, 4105, 0, 192, 0, 5455, 0, 435978, 0, 0, 0, 1180, 28457, 0, 0, 7, 0, 1981, 0, 0, 107, 0, 0, 0, 100058, 0, 241, 0, 74, 0, 0, 0, 814, 19290, 0, 5993, 0, 0, 0, 4683, 0, 0, 0, 1213, 0, 0, 0, 9223, 0, 3, 39389, 0, 2060, 0, 0, 0, 58, 0, 0, 0, 205, 0, 0, 141, 0, 0, 1239, 32, 0, 0, 3811, 0, 0, 17, 917, 0, 0, 0, 174206, 0, 117964, 0, 0, 2844, 723, 0, 0, 13, 77, 17, 0, 600, 0, 687, 36652, 0, 64677, 16, 41, 0, 0, 17, 13, 0, 10, 0, 4226, 12, 0, 0, 451, 0, 16, 0, 0, 1012, 0, 0, 0, 28886, 0, 0, 0, 268, 0, 0, 0, 8, 0, 0, 140, 60, 0, 10, 0, 0, 28735, 0, 0, 108, 0, 0, 1844, 0, 0, 15072, 108, 448, 0, 0, 0, 2915, 0, 2512, 0, 0, 4066, 144, 0, 98566, 0, 0, 0, 53198, 0, 92, 22, 0, 56, 2454, 0, 66, 348, 0, 0, 0, 50, 0, 0, 0, 239050, 0, 0, 0, 584, 0, 0, 552, 145, 5474, 0, 0, 245289, 0, 30, 19137, 0, 0, 2725, 0, 429, 0, 0, 201076, 0, 8221, 0, 0, 0, 63, 0, 0, 0, 75419, 0, 258416, 0, 0, 0, 1415, 0, 0, 143, 403, 0, 0, 0, 13071, 0, 0, 0, 273, 0, 0, 0, 158, 1046, 0, 0, 0, 20127, 0, 0, 0, 264698, 0, 0, 4670, 0, 28455, 0, 0, 38165, 0, 0, 5706, 314, 0, 0, 2447, 18, 0, 0, 0, 384798, 0, 0, 0, 90, 0, 0, 0, 534058, 0, 0, 34962, 0, 0, 18590, 0, 0, 5024, 0, 0, 37, 0, 0, 185, 0, 0, 0, 124826, 0, 0, 0, 190, 71887, 0, 0, 0, 6875, 0, 0, 0, 1390, 9434, 0, 73, 0, 0, 15321, 0, 0, 152435, 0, 0, 0, 4588, 0, 111, 216745, 0, 26, 0, 0, 302, 0, 6025, 0, 22090, 0, 1536, 0, 132, 0, 0, 123, 0, 338, 0, 6, 0, 0, 0, 540, 0, 0, 0, 91321, 24020, 0, 57283, 0, 0, 0, 75, 0, 0, 38, 0, 0, 0, 415, 0, 600671, 0, 0, 943, 0, 0, 0, 14, 157, 0, 0, 0, 1934, 0, 0, 311, 0, 0, 237, 96, 0, 7224, 0, 7569, 0, 788, 9432, 0, 649, 0, 0, 0, 230, 0, 0, 0, 43, 27, 0, 0, 644577, 198, 0, 521, 0, 28, 0, 0, 2006, 0, 0, 36022, 0, 0, 0, 9039, 0, 0, 0, 141, 0, 0, 39236, 12, 102, 0, 31333, 196, 0, 65982, 0, 0, 15, 0, 0, 0, 61, 0, 79, 0, 0, 373, 0, 0, 0, 31026, 3382, 0, 140, 0, 0, 283, 132, 0, 0, 937, 0, 0, 0, 4018, 0, 0, 72, 0, 0, 24508, 19718, 0, 0, 1107, 2533, 17, 0, 10, 271827, 0, 40106, 0, 0, 0, 61476, 141605, 0, 0, 0, 152, 0, 0, 4225, 28, 35, 12, 0, 0, 0, 5593, 0, 330, 0, 308, 0, 4, 0, 0, 286, 1634, 139, 0, 0, 637, 636, 0, 0, 0, 15, 0, 0, 0, 943, 0, 22, 20892, 0, 4790, 0, 0, 0, 165, 0, 0, 0, 2045, 0, 0, 0, 437580, 0, 14, 19, 132, 0, 474, 0, 0, 901, 0, 18, 0, 0, 15, 8155, 0, 2510, 0, 0, 0, 283, 3, 9475, 0, 0, 0, 154, 32, 0, 55576, 0, 0, 566, 0, 0, 0, 1002, 0, 0, 37, 0, 0, 0, 37, 0, 0, 0, 50031, 0, 0, 0, 8, 144, 3782, 0, 613, 17445, 0, 29763, 0, 0, 55873, 0, 64, 0, 0, 9671, 190, 0, 0, 0, 10, 0, 3, 447, 0, 0, 1086, 1234, 0, 1333, 1255, 0, 0, 300, 0, 36864, 0, 7150, 0, 6, 114, 0, 51683, 0, 0, 69, 9, 0, 55, 0, 0, 18, 0, 33, 258, 0, 0, 16, 251663, 69, 0, 0, 6, 0, 0, 0, 227092, 0, 0, 0, 200, 6483, 0, 0, 101727, 18809, 0, 0, 643904, 0, 19, 0, 473281, 1947, 0, 0, 16, 34735, 0, 30435, 0, 7568, 0, 0, 12, 0, 0, 202470, 0, 0, 0, 181617, 0, 831, 0, 77, 0, 592, 0, 0, 0, 17374, 0, 0, 0, 1762, 0, 611, 0, 154969, 9, 0, 162009, 0, 633729, 0, 1509, 190, 0, 0, 14184, 35, 0, 4954, 0, 0, 0, 13393, 0, 0, 0, 21, 79, 0, 78, 0, 0, 0, 17, 0, 0, 0, 78489, 0, 0, 0, 1160, 0, 19510, 287117, 0, 224, 0, 0, 23577, 0, 298, 0, 2257, 0, 41, 0, 22027, 11683, 0, 28, 0, 0, 0, 134, 0, 0, 0, 8932, 0, 38453, 0, 0, 18530, 0, 23692, 0, 0, 0, 964, 4871, 0, 0, 854, 0, 0, 0, 313667, 221766, 0, 7, 0, 3658, 0, 0, 8403, 0, 211189, 0, 0, 75565, 78853, 0, 0, 49, 0, 0, 0, 24, 0, 0, 0, 1214, 0, 0, 117257, 0, 0, 0, 557, 0, 0, 0, 255, 0, 0, 0, 7, 1084, 0, 0, 0, 237199, 0, 0, 0, 111680, 0, 0, 0, 9876, 0, 0, 0, 8164, 524, 0, 0, 1349, 0, 62747, 776, 0, 0, 97138, 0, 0, 253, 270, 0, 36900, 0, 0, 0, 12, 0, 52997, 0, 0, 30, 126643, 0, 0, 0, 820, 0, 0, 0, 211513, 48533, 39, 93, 0, 16908, 0, 0, 0, 7227, 0, 0, 0, 10491, 0, 0, 18, 0, 0, 888, 0, 0, 0, 20076, 0, 0, 0, 145226, 16, 99, 0, 0, 81227, 0, 0, 110, 0, 0, 543, 0, 24, 253983, 557, 0, 0, 535, 0, 147, 140, 0, 0, 26, 0, 0, 0, 15418, 0, 0, 283, 0, 17, 11, 0, 0, 0, 738, 0, 0, 38992, 16, 0, 0, 4645, 0, 0, 326, 0, 0, 4656, 0, 64175, 0, 0, 599, 0, 0, 0, 1723, 0, 0, 0, 7465, 900, 0, 565, 0, 0, 0, 197, 0, 777, 0, 0, 0, 765, 0, 313653, 0, 172256, 0, 0, 0, 224707, 0, 0, 10, 55098, 0, 66, 0, 0, 309, 0, 0, 1234, 0, 0, 14368, 0, 65095, 0, 302041, 3084, 0, 0, 2094, 0, 0, 0, 11, 2646, 0, 0, 0, 41911, 0, 14, 0, 0, 637, 45320, 0, 0, 0, 39591, 2008, 0, 0, 0, 908, 122278, 0, 0, 16627, 0, 0, 10011, 0, 8557, 0, 0, 0, 39834, 0, 0, 0, 15, 3145, 0, 0, 0, 492005, 27051, 0, 0, 10120, 0, 8, 0, 0, 0, 34243, 5583, 0, 0, 54, 0, 0, 10909, 0, 0, 28, 413, 0, 297178, 0, 0, 151, 0, 0, 19252, 49308, 0, 0, 0, 23, 0, 0, 42159, 9577, 2387, 0, 0, 0, 231, 0, 0, 342, 0, 0, 840, 0, 0, 0, 5, 44, 0, 0, 0, 9844, 0, 0, 202, 0, 0, 6760, 0, 0, 252101, 14, 34, 0, 70789, 0, 0, 7, 0, 10523, 0, 0, 0, 10, 0, 1893, 0, 0, 59, 0, 5860, 515, 0, 0, 142775, 1215, 0, 0, 18569, 0, 0, 0, 18663, 0, 0, 92, 0, 0, 29, 0, 0, 0, 38127, 0, 0, 186, 0, 0, 4015, 0, 0, 21501, 322, 154721, 0, 0, 0, 74, 185, 3829, 0, 24088, 0, 0, 49502, 0, 0, 762, 0, 26, 0, 0, 0, 9754, 0, 0, 293644, 0, 9740, 0, 0, 0, 3226, 0, 69445, 0, 0, 23723, 0, 0, 0, 1913, 0, 0, 0, 228, 0, 0, 19, 0, 0, 0, 19330, 0, 0, 0, 18687, 0, 0, 29, 493, 0, 0, 37511, 0, 210, 0, 0, 0, 8, 0, 0, 447916, 3447, 0, 0, 0, 6, 0, 589595, 0, 0, 0, 534 };
            int i = 0;
            int sum = expected.Sum();
            array = (from a in expected
                     from r in Enumerable.Repeat(i++, a)
                     select r
                        ).ToArray();
        }

        public int[] AppearOnceData(int lastNumber, int once)
        {
            int[] array = new int[lastNumber * 2 + 1];
            for (int i = 0, j = 0; j <= lastNumber; i += 2, j++)
            {
                if (j == once)
                {
                    array[i] = j;
                    i--;
                }
                else
                {
                    array[i] = array[i + 1] = j;
                }
            }
            return array;
        }
    }
}

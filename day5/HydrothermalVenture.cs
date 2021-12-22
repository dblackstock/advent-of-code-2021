using System;

namespace advent_of_code_2021
{
	class HydrothermalVenture
	{
		public static void FindOverlaps()
		{
			Coordinates[] coordsArray = new Coordinates[] { new Coordinates(644, 38, 644, 265), new Coordinates(941, 468, 941, 89), new Coordinates(807, 552, 618, 363), new Coordinates(896, 510, 896, 744), new Coordinates(227, 909, 227, 745), new Coordinates(24, 66, 946, 988), new Coordinates(563, 529, 563, 270), new Coordinates(894, 707, 359, 172), new Coordinates(146, 253, 146, 569), new Coordinates(544, 683, 140, 683), new Coordinates(755, 612, 755, 463), new Coordinates(394, 320, 891, 320), new Coordinates(68, 616, 68, 628), new Coordinates(801, 770, 801, 942), new Coordinates(650, 290, 580, 360), new Coordinates(376, 18, 181, 213), new Coordinates(285, 391, 805, 911), new Coordinates(57, 153, 501, 153), new Coordinates(686, 301, 686, 316), new Coordinates(81, 971, 683, 369), new Coordinates(75, 456, 75, 355), new Coordinates(769, 59, 769, 81), new Coordinates(49, 958, 49, 718), new Coordinates(492, 754, 492, 256), new Coordinates(606, 133, 391, 133), new Coordinates(134, 683, 134, 656), new Coordinates(195, 463, 658, 926), new Coordinates(982, 498, 982, 927), new Coordinates(841, 122, 889, 74), new Coordinates(968, 891, 968, 189), new Coordinates(104, 941, 104, 868), new Coordinates(801, 450, 272, 979), new Coordinates(212, 749, 212, 366), new Coordinates(880, 928, 880, 757), new Coordinates(503, 483, 283, 263), new Coordinates(792, 924, 792, 540), new Coordinates(58, 87, 905, 934), new Coordinates(275, 661, 36, 422), new Coordinates(475, 654, 466, 645), new Coordinates(34, 946, 969, 11), new Coordinates(725, 664, 725, 150), new Coordinates(837, 680, 837, 952), new Coordinates(109, 987, 644, 452), new Coordinates(860, 984, 860, 691), new Coordinates(672, 800, 107, 235), new Coordinates(216, 888, 301, 888), new Coordinates(399, 676, 718, 357), new Coordinates(957, 544, 784, 544), new Coordinates(677, 743, 633, 743), new Coordinates(491, 866, 77, 452), new Coordinates(967, 949, 45, 27), new Coordinates(659, 699, 659, 27), new Coordinates(987, 116, 696, 116), new Coordinates(465, 847, 309, 847), new Coordinates(353, 19, 353, 627), new Coordinates(265, 713, 592, 386), new Coordinates(541, 765, 461, 765), new Coordinates(21, 409, 895, 409), new Coordinates(950, 149, 766, 149), new Coordinates(856, 889, 895, 889), new Coordinates(335, 962, 485, 812), new Coordinates(425, 774, 400, 749), new Coordinates(71, 932, 989, 14), new Coordinates(484, 974, 44, 974), new Coordinates(86, 797, 86, 470), new Coordinates(876, 962, 876, 384), new Coordinates(45, 631, 169, 507), new Coordinates(161, 789, 523, 427), new Coordinates(791, 640, 791, 581), new Coordinates(415, 170, 835, 590), new Coordinates(299, 275, 988, 964), new Coordinates(105, 233, 231, 359), new Coordinates(202, 226, 202, 958), new Coordinates(814, 717, 618, 521), new Coordinates(185, 442, 559, 68), new Coordinates(26, 149, 665, 149), new Coordinates(673, 369, 247, 795), new Coordinates(171, 963, 171, 46), new Coordinates(689, 801, 94, 206), new Coordinates(619, 243, 619, 637), new Coordinates(426, 245, 660, 11), new Coordinates(47, 503, 47, 179), new Coordinates(341, 363, 487, 217), new Coordinates(371, 774, 371, 871), new Coordinates(781, 794, 781, 180), new Coordinates(391, 632, 92, 632), new Coordinates(517, 150, 517, 715), new Coordinates(903, 10, 18, 895), new Coordinates(34, 500, 426, 500), new Coordinates(82, 955, 886, 151), new Coordinates(142, 297, 142, 527), new Coordinates(60, 965, 36, 965), new Coordinates(250, 807, 372, 685), new Coordinates(227, 393, 610, 776), new Coordinates(269, 893, 269, 556), new Coordinates(969, 223, 611, 223), new Coordinates(255, 92, 194, 92), new Coordinates(220, 233, 958, 233), new Coordinates(144, 209, 144, 979), new Coordinates(48, 413, 48, 195), new Coordinates(209, 151, 648, 590), new Coordinates(867, 648, 871, 644), new Coordinates(499, 555, 807, 555), new Coordinates(571, 729, 865, 435), new Coordinates(683, 151, 485, 151), new Coordinates(803, 26, 803, 691), new Coordinates(533, 921, 300, 688), new Coordinates(625, 695, 483, 553), new Coordinates(719, 370, 139, 950), new Coordinates(981, 17, 16, 982), new Coordinates(367, 617, 367, 636), new Coordinates(249, 644, 835, 644), new Coordinates(260, 825, 260, 519), new Coordinates(275, 144, 275, 315), new Coordinates(767, 314, 962, 119), new Coordinates(76, 625, 76, 166), new Coordinates(403, 680, 313, 680), new Coordinates(977, 21, 16, 982), new Coordinates(578, 753, 271, 753), new Coordinates(212, 358, 477, 623), new Coordinates(596, 220, 868, 220), new Coordinates(67, 797, 935, 797), new Coordinates(181, 107, 181, 379), new Coordinates(741, 332, 419, 10), new Coordinates(732, 827, 732, 989), new Coordinates(835, 111, 436, 510), new Coordinates(480, 328, 480, 682), new Coordinates(327, 673, 327, 70), new Coordinates(911, 547, 833, 625), new Coordinates(944, 509, 874, 579), new Coordinates(169, 340, 731, 902), new Coordinates(156, 842, 825, 173), new Coordinates(976, 40, 51, 965), new Coordinates(199, 416, 916, 416), new Coordinates(51, 970, 792, 229), new Coordinates(14, 577, 501, 577), new Coordinates(246, 464, 246, 289), new Coordinates(641, 464, 100, 464), new Coordinates(984, 11, 43, 952), new Coordinates(548, 36, 156, 428), new Coordinates(519, 799, 519, 43), new Coordinates(332, 364, 332, 774), new Coordinates(85, 123, 85, 753), new Coordinates(778, 12, 40, 750), new Coordinates(507, 56, 507, 840), new Coordinates(973, 632, 670, 632), new Coordinates(895, 928, 37, 70), new Coordinates(661, 784, 661, 718), new Coordinates(114, 25, 938, 849), new Coordinates(428, 752, 428, 543), new Coordinates(357, 270, 957, 870), new Coordinates(27, 70, 899, 942), new Coordinates(85, 780, 747, 780), new Coordinates(717, 565, 951, 565), new Coordinates(191, 748, 651, 748), new Coordinates(679, 301, 679, 417), new Coordinates(150, 266, 150, 184), new Coordinates(774, 964, 64, 254), new Coordinates(34, 248, 34, 279), new Coordinates(782, 610, 802, 610), new Coordinates(109, 146, 822, 859), new Coordinates(825, 848, 825, 666), new Coordinates(251, 718, 615, 718), new Coordinates(912, 722, 289, 722), new Coordinates(729, 579, 729, 889), new Coordinates(214, 756, 214, 716), new Coordinates(58, 497, 58, 927), new Coordinates(62, 55, 742, 55), new Coordinates(110, 429, 110, 154), new Coordinates(55, 794, 638, 794), new Coordinates(182, 96, 676, 96), new Coordinates(632, 334, 202, 764), new Coordinates(36, 541, 36, 397), new Coordinates(191, 819, 191, 277), new Coordinates(971, 491, 839, 491), new Coordinates(849, 561, 538, 250), new Coordinates(176, 523, 10, 689), new Coordinates(162, 638, 717, 638), new Coordinates(132, 843, 646, 329), new Coordinates(873, 67, 873, 389), new Coordinates(167, 631, 167, 473), new Coordinates(49, 337, 465, 337), new Coordinates(550, 429, 438, 429), new Coordinates(305, 720, 476, 720), new Coordinates(547, 636, 547, 902), new Coordinates(21, 627, 49, 627), new Coordinates(286, 70, 989, 70), new Coordinates(87, 930, 896, 121), new Coordinates(659, 916, 200, 916), new Coordinates(234, 589, 234, 308), new Coordinates(530, 962, 90, 962), new Coordinates(366, 478, 676, 788), new Coordinates(284, 520, 284, 546), new Coordinates(580, 74, 146, 508), new Coordinates(561, 977, 561, 237), new Coordinates(85, 150, 804, 869), new Coordinates(740, 850, 159, 269), new Coordinates(458, 705, 458, 639), new Coordinates(969, 563, 381, 563), new Coordinates(139, 439, 139, 263), new Coordinates(135, 971, 908, 198), new Coordinates(440, 632, 102, 632), new Coordinates(446, 549, 446, 734), new Coordinates(24, 49, 212, 237), new Coordinates(692, 882, 527, 882), new Coordinates(156, 895, 156, 239), new Coordinates(359, 246, 359, 603), new Coordinates(12, 349, 604, 941), new Coordinates(375, 161, 732, 161), new Coordinates(674, 287, 322, 287), new Coordinates(902, 957, 328, 383), new Coordinates(352, 185, 352, 766), new Coordinates(222, 205, 222, 419), new Coordinates(769, 815, 769, 739), new Coordinates(83, 147, 880, 147), new Coordinates(136, 148, 136, 279), new Coordinates(807, 241, 439, 241), new Coordinates(464, 240, 478, 254), new Coordinates(37, 839, 646, 839), new Coordinates(351, 316, 639, 604), new Coordinates(449, 492, 449, 125), new Coordinates(69, 892, 933, 28), new Coordinates(565, 161, 598, 161), new Coordinates(147, 802, 905, 44), new Coordinates(809, 861, 38, 90), new Coordinates(34, 80, 34, 538), new Coordinates(896, 405, 582, 405), new Coordinates(474, 201, 893, 201), new Coordinates(289, 64, 975, 750), new Coordinates(378, 785, 375, 782), new Coordinates(709, 472, 357, 472), new Coordinates(17, 14, 987, 984), new Coordinates(625, 46, 647, 46), new Coordinates(20, 84, 914, 978), new Coordinates(364, 811, 397, 811), new Coordinates(395, 726, 628, 726), new Coordinates(831, 89, 593, 89), new Coordinates(370, 562, 827, 562), new Coordinates(278, 371, 609, 40), new Coordinates(904, 529, 391, 16), new Coordinates(232, 829, 232, 63), new Coordinates(927, 121, 194, 854), new Coordinates(547, 280, 547, 895), new Coordinates(292, 904, 292, 897), new Coordinates(99, 525, 99, 868), new Coordinates(371, 44, 643, 44), new Coordinates(942, 74, 986, 118), new Coordinates(708, 179, 110, 179), new Coordinates(485, 637, 713, 637), new Coordinates(477, 512, 102, 137), new Coordinates(636, 657, 727, 657), new Coordinates(686, 564, 256, 564), new Coordinates(636, 169, 377, 169), new Coordinates(627, 943, 627, 703), new Coordinates(987, 795, 987, 758), new Coordinates(364, 827, 642, 827), new Coordinates(613, 694, 864, 945), new Coordinates(910, 521, 777, 654), new Coordinates(119, 394, 22, 394), new Coordinates(594, 439, 515, 360), new Coordinates(177, 11, 177, 73), new Coordinates(456, 628, 456, 467), new Coordinates(246, 214, 594, 562), new Coordinates(47, 790, 47, 491), new Coordinates(788, 21, 788, 343), new Coordinates(136, 847, 136, 543), new Coordinates(958, 302, 733, 302), new Coordinates(50, 981, 923, 108), new Coordinates(298, 179, 298, 921), new Coordinates(962, 644, 93, 644), new Coordinates(988, 671, 988, 258), new Coordinates(646, 140, 646, 852), new Coordinates(721, 264, 721, 563), new Coordinates(972, 407, 684, 119), new Coordinates(245, 422, 401, 422), new Coordinates(16, 494, 16, 16), new Coordinates(564, 72, 361, 72), new Coordinates(436, 390, 166, 120), new Coordinates(511, 571, 241, 571), new Coordinates(259, 215, 259, 975), new Coordinates(648, 841, 898, 841), new Coordinates(918, 881, 438, 401), new Coordinates(458, 561, 752, 855), new Coordinates(791, 192, 319, 192), new Coordinates(383, 929, 217, 929), new Coordinates(733, 26, 527, 26), new Coordinates(620, 160, 620, 734), new Coordinates(818, 181, 61, 181), new Coordinates(39, 21, 927, 909), new Coordinates(952, 208, 952, 749), new Coordinates(194, 55, 304, 55), new Coordinates(519, 673, 519, 875), new Coordinates(730, 919, 733, 919), new Coordinates(963, 269, 933, 299), new Coordinates(707, 112, 178, 112), new Coordinates(924, 349, 264, 349), new Coordinates(910, 94, 96, 94), new Coordinates(747, 289, 89, 947), new Coordinates(164, 956, 164, 655), new Coordinates(264, 300, 753, 789), new Coordinates(207, 672, 207, 488), new Coordinates(243, 838, 812, 269), new Coordinates(455, 320, 425, 320), new Coordinates(59, 964, 59, 841), new Coordinates(350, 373, 526, 549), new Coordinates(604, 683, 604, 83), new Coordinates(537, 281, 537, 933), new Coordinates(737, 634, 737, 28), new Coordinates(92, 909, 725, 276), new Coordinates(859, 335, 859, 487), new Coordinates(605, 495, 371, 495), new Coordinates(783, 155, 783, 930), new Coordinates(388, 591, 388, 133), new Coordinates(374, 634, 472, 634), new Coordinates(963, 914, 64, 15), new Coordinates(57, 435, 140, 435), new Coordinates(759, 619, 105, 619), new Coordinates(326, 501, 326, 821), new Coordinates(942, 136, 414, 136), new Coordinates(490, 376, 490, 260), new Coordinates(377, 59, 377, 773), new Coordinates(894, 169, 99, 964), new Coordinates(350, 511, 726, 511), new Coordinates(787, 728, 787, 750), new Coordinates(688, 11, 688, 68), new Coordinates(107, 514, 183, 514), new Coordinates(861, 12, 22, 851), new Coordinates(149, 49, 149, 713), new Coordinates(826, 737, 890, 737), new Coordinates(299, 307, 299, 549), new Coordinates(251, 648, 862, 37), new Coordinates(898, 85, 412, 85), new Coordinates(936, 168, 845, 168), new Coordinates(278, 677, 302, 677), new Coordinates(493, 878, 493, 133), new Coordinates(539, 205, 539, 522), new Coordinates(412, 495, 412, 929), new Coordinates(334, 605, 334, 817), new Coordinates(68, 462, 462, 856), new Coordinates(234, 134, 234, 942), new Coordinates(293, 823, 678, 823), new Coordinates(852, 874, 158, 874), new Coordinates(859, 612, 435, 612), new Coordinates(10, 876, 613, 273), new Coordinates(370, 13, 118, 13), new Coordinates(616, 774, 14, 172), new Coordinates(193, 543, 81, 543), new Coordinates(784, 179, 14, 949), new Coordinates(324, 533, 153, 533), new Coordinates(15, 976, 976, 15), new Coordinates(943, 52, 20, 975), new Coordinates(100, 34, 671, 605), new Coordinates(140, 552, 140, 27), new Coordinates(448, 497, 186, 497), new Coordinates(734, 355, 734, 933), new Coordinates(544, 131, 259, 131), new Coordinates(193, 84, 663, 84), new Coordinates(190, 949, 833, 306), new Coordinates(430, 34, 328, 34), new Coordinates(21, 46, 483, 508), new Coordinates(621, 202, 98, 202), new Coordinates(196, 874, 889, 181), new Coordinates(106, 217, 850, 961), new Coordinates(701, 891, 488, 678), new Coordinates(21, 597, 894, 597), new Coordinates(249, 21, 249, 614), new Coordinates(887, 808, 887, 948), new Coordinates(255, 711, 913, 53), new Coordinates(173, 447, 173, 78), new Coordinates(956, 224, 956, 747), new Coordinates(513, 882, 48, 417), new Coordinates(772, 591, 930, 591), new Coordinates(976, 98, 86, 988), new Coordinates(264, 67, 264, 931), new Coordinates(987, 982, 48, 43), new Coordinates(494, 514, 494, 416), new Coordinates(867, 785, 556, 474), new Coordinates(350, 902, 257, 902), new Coordinates(978, 977, 978, 735), new Coordinates(312, 240, 371, 240), new Coordinates(890, 112, 890, 662), new Coordinates(753, 327, 427, 653), new Coordinates(83, 888, 927, 44), new Coordinates(142, 480, 12, 480), new Coordinates(965, 39, 85, 919), new Coordinates(158, 926, 158, 801), new Coordinates(439, 22, 439, 860), new Coordinates(10, 26, 765, 781), new Coordinates(775, 838, 775, 732), new Coordinates(871, 607, 871, 288), new Coordinates(337, 850, 337, 533), new Coordinates(89, 581, 89, 582), new Coordinates(524, 977, 524, 88), new Coordinates(473, 283, 639, 449), new Coordinates(23, 324, 23, 372), new Coordinates(671, 486, 278, 879), new Coordinates(266, 98, 989, 98), new Coordinates(51, 947, 634, 947), new Coordinates(47, 18, 47, 43), new Coordinates(95, 239, 609, 753), new Coordinates(953, 34, 71, 916), new Coordinates(243, 685, 243, 427), new Coordinates(642, 537, 304, 199), new Coordinates(545, 41, 914, 41), new Coordinates(112, 860, 112, 159), new Coordinates(12, 12, 989, 989), new Coordinates(622, 907, 648, 907), new Coordinates(230, 983, 230, 941), new Coordinates(111, 868, 852, 127), new Coordinates(315, 895, 799, 411), new Coordinates(771, 533, 584, 720), new Coordinates(65, 492, 657, 492), new Coordinates(820, 315, 820, 627), new Coordinates(710, 554, 829, 554), new Coordinates(100, 967, 877, 190), new Coordinates(530, 733, 530, 202), new Coordinates(880, 28, 83, 825), new Coordinates(914, 448, 494, 28), new Coordinates(886, 344, 966, 344), new Coordinates(782, 923, 857, 848), new Coordinates(597, 632, 597, 946), new Coordinates(366, 789, 366, 96), new Coordinates(568, 834, 187, 834), new Coordinates(451, 687, 224, 687), new Coordinates(123, 12, 914, 803), new Coordinates(734, 42, 526, 42), new Coordinates(844, 116, 844, 521), new Coordinates(744, 976, 744, 792), new Coordinates(337, 837, 617, 837), new Coordinates(848, 139, 848, 571), new Coordinates(853, 264, 112, 264), new Coordinates(986, 965, 92, 71), new Coordinates(888, 892, 53, 57), new Coordinates(150, 342, 150, 516), new Coordinates(457, 264, 796, 264), new Coordinates(544, 595, 544, 406), new Coordinates(243, 118, 482, 357), new Coordinates(138, 804, 138, 646), new Coordinates(99, 80, 99, 34), new Coordinates(442, 883, 442, 165), new Coordinates(428, 72, 428, 826), new Coordinates(450, 815, 901, 364), new Coordinates(852, 516, 852, 384), new Coordinates(13, 969, 972, 10), new Coordinates(921, 50, 32, 939), new Coordinates(969, 470, 969, 539), new Coordinates(691, 238, 763, 238), new Coordinates(171, 733, 823, 81), new Coordinates(722, 963, 21, 262), new Coordinates(849, 203, 849, 151), new Coordinates(12, 99, 884, 971), new Coordinates(903, 240, 148, 240), new Coordinates(633, 140, 633, 202), new Coordinates(194, 393, 747, 393), new Coordinates(748, 43, 126, 665), new Coordinates(182, 155, 182, 298), new Coordinates(668, 814, 668, 306), new Coordinates(619, 384, 255, 384), new Coordinates(166, 341, 795, 970), new Coordinates(898, 870, 57, 29), new Coordinates(976, 148, 976, 244), new Coordinates(386, 525, 662, 249), new Coordinates(719, 67, 131, 655), new Coordinates(419, 847, 188, 847), new Coordinates(953, 823, 743, 823), new Coordinates(307, 299, 307, 78), new Coordinates(948, 253, 756, 253), new Coordinates(926, 938, 46, 58), new Coordinates(982, 618, 652, 618), new Coordinates(539, 742, 539, 177), new Coordinates(531, 974, 531, 781), new Coordinates(880, 922, 283, 325), new Coordinates(707, 257, 707, 673), new Coordinates(327, 308, 930, 911), new Coordinates(526, 170, 980, 624), new Coordinates(445, 653, 445, 986), new Coordinates(842, 737, 754, 737), new Coordinates(847, 982, 16, 151), new Coordinates(137, 426, 292, 271), new Coordinates(126, 556, 50, 556), new Coordinates(168, 766, 168, 767), new Coordinates(152, 46, 363, 46), new Coordinates(50, 381, 760, 381), new Coordinates(43, 943, 43, 374), new Coordinates(45, 964, 956, 53), new Coordinates(37, 403, 576, 403), new Coordinates(130, 317, 576, 763), new Coordinates(882, 840, 179, 137), new Coordinates(572, 608, 572, 274), new Coordinates(874, 977, 32, 135), new Coordinates(794, 56, 730, 120), new Coordinates(812, 841, 812, 440), new Coordinates(111, 66, 137, 92), new Coordinates(255, 287, 255, 787), new Coordinates(121, 137, 121, 63), new Coordinates(81, 811, 81, 586), new Coordinates(303, 365, 910, 972), new Coordinates(177, 134, 962, 919), new Coordinates(405, 41, 405, 645), new Coordinates(219, 934, 441, 934) };

			Console.WriteLine("5.1 find horizontal and vertical overlaps");

			// create an array which will be the whole map
			int largestX = 0;
			int largestY = 0;

			foreach (var coords in coordsArray)
			{
				largestX = Math.Max(largestX, Math.Max(coords.xOne, coords.xTwo));
				largestY = Math.Max(largestY, Math.Max(coords.yOne, coords.yTwo));
			}

			int[,] map = new int[largestX, largestY]; // the coordinates themselves will need to be reduced by 1 to fit with the 0-indexed arrays

			foreach (var coords in coordsArray)
			{
				if (coords.isVertical())
				{
					int smallY = Math.Min(coords.yOne, coords.yTwo);
					int bigY = Math.Max(coords.yOne, coords.yTwo);
					for (int i = smallY - 1; i < bigY; i++)
					{
						map[coords.xOne - 1, i]++;
					}
				}

				if (coords.isHorizontal())
				{
					int smallX = Math.Min(coords.xOne, coords.xTwo);
					int bigX = Math.Max(coords.xOne, coords.xTwo);
					for (int i = smallX - 1; i < bigX; i++)
					{
						map[i, coords.yOne - 1]++;
					}
				}
			}

			// count overlaps
			int overlaps = 0;
			for (int i = 0; i < map.GetLength(0); i++)
			{
				for (int j = 0; j < map.GetLength(1); j++)
				{
					if (map[i, j] > 1)
					{
						overlaps++;
					}
				}
			}

			Console.WriteLine($"There are {overlaps} horizontal+vertical overlap(s) on the map, corresponding to this many dangerous vent locations");

			Console.WriteLine("5.2 find horizontal and vertical and diagonal overlaps");

			foreach (var coords in coordsArray)
			{

				if (coords.isDiagonal())
				{
					int xIncreases = 1;
					if (coords.xOne > coords.xTwo)
					{
						xIncreases = -1;
					}
					int yIncreases = 1;
					if (coords.yOne > coords.yTwo)
					{
						yIncreases = -1;
					}
					int numberOfSteps = Math.Abs(coords.xOne - coords.xTwo);

					for (int i = 0; i <= numberOfSteps; i++)
					{
						int currentXCoord = (coords.xOne - 1) + i * xIncreases;
						int currentYCoord = (coords.yOne - 1) + i * yIncreases;
						map[currentXCoord, currentYCoord]++;
					}

				}

			}

			// count overlaps
			overlaps = 0;
			for (int i = 0; i < map.GetLength(0); i++)
			{
				for (int j = 0; j < map.GetLength(1); j++)
				{
					if (map[i, j] > 1)
					{
						overlaps++;
					}
				}
			}

			Console.WriteLine($"There are {overlaps} horizontal+vertical+diagonal overlap(s) on the map, corresponding to this many dangerous vent locations");
		}
	}

	class Coordinates
	{

		public int xOne, yOne, xTwo, yTwo; // not bothering with private class variables

		public Coordinates(int xOne, int yOne, int xTwo, int yTwo)
		{
			this.xOne = xOne;
			this.yOne = yOne;
			this.xTwo = xTwo;
			this.yTwo = yTwo;
		}

		public bool isHorizontal()
		{
			if (yOne == yTwo)
			{
				return true;
			}
			return false;
		}

		public bool isVertical()
		{
			if (xOne == xTwo)
			{
				return true;
			}
			return false;
		}

		public bool isDiagonal()
		{
			if (Math.Abs(xOne - xTwo) == Math.Abs(yOne - yTwo))
			{
				return true;
			}
			return false;
		}
	}
}

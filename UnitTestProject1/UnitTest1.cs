using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaiTrainMileageCalc;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        #region StationMileages
        public List<StationMileage> StationMileages = new List<StationMileage>()
        {
     new StationMileage(){ TrainId=1243, TrainName="仁德",Mileage=362.20, LineGroup=0},
new StationMileage(){ TrainId=6103, TrainName="海科館",Mileage=4.20, LineGroup=10},
new StationMileage(){ TrainId=1001, TrainName="基隆",Mileage=0.00, LineGroup=0},
new StationMileage(){ TrainId=1002, TrainName="八堵",Mileage=3.70, LineGroup=0},
new StationMileage(){ TrainId=1002, TrainName="八堵",Mileage=0.00, LineGroup=2},
new StationMileage(){ TrainId=1003, TrainName="七堵",Mileage=6.00, LineGroup=0},
new StationMileage(){ TrainId=1004, TrainName="五堵",Mileage=11.70, LineGroup=0},
new StationMileage(){ TrainId=1005, TrainName="汐止",Mileage=13.10, LineGroup=0},
new StationMileage(){ TrainId=1006, TrainName="南港",Mileage=19.10, LineGroup=0},
new StationMileage(){ TrainId=1007, TrainName="松山",Mileage=21.90, LineGroup=0},
new StationMileage(){ TrainId=1008, TrainName="台北",Mileage=28.30, LineGroup=0},
new StationMileage(){ TrainId=1009, TrainName="萬華",Mileage=31.10, LineGroup=0},
new StationMileage(){ TrainId=1011, TrainName="板橋",Mileage=35.50, LineGroup=0},
new StationMileage(){ TrainId=1012, TrainName="樹林",Mileage=40.90, LineGroup=0},
new StationMileage(){ TrainId=1013, TrainName="山佳",Mileage=44.80, LineGroup=0},
new StationMileage(){ TrainId=1014, TrainName="鶯歌",Mileage=49.20, LineGroup=0},
new StationMileage(){ TrainId=1015, TrainName="桃園",Mileage=57.40, LineGroup=0},
new StationMileage(){ TrainId=1016, TrainName="內壢",Mileage=63.30, LineGroup=0},
new StationMileage(){ TrainId=1017, TrainName="中壢",Mileage=67.30, LineGroup=0},
new StationMileage(){ TrainId=1018, TrainName="埔心",Mileage=73.10, LineGroup=0},
new StationMileage(){ TrainId=1019, TrainName="楊梅",Mileage=77.10, LineGroup=0},
new StationMileage(){ TrainId=1020, TrainName="富岡",Mileage=83.90, LineGroup=0},
new StationMileage(){ TrainId=1021, TrainName="湖口",Mileage=89.60, LineGroup=0},
new StationMileage(){ TrainId=1022, TrainName="新豐",Mileage=95.80, LineGroup=0},
new StationMileage(){ TrainId=1023, TrainName="竹北",Mileage=100.60, LineGroup=0},
new StationMileage(){ TrainId=1024, TrainName="北新竹",Mileage=105.00, LineGroup=0},
new StationMileage(){ TrainId=1024, TrainName="北新竹",Mileage=1.40, LineGroup=5},
new StationMileage(){ TrainId=1025, TrainName="新竹",Mileage=106.40, LineGroup=0},
new StationMileage(){ TrainId=1025, TrainName="新竹",Mileage=0.00, LineGroup=5},
new StationMileage(){ TrainId=1026, TrainName="香山",Mileage=114.40, LineGroup=0},
new StationMileage(){ TrainId=1027, TrainName="崎頂",Mileage=120.80, LineGroup=0},
new StationMileage(){ TrainId=1028, TrainName="竹南",Mileage=125.40, LineGroup=0},
new StationMileage(){ TrainId=1028, TrainName="竹南",Mileage=0.00, LineGroup=1},
new StationMileage(){ TrainId=1029, TrainName="三坑",Mileage=1.30, LineGroup=0},
new StationMileage(){ TrainId=1030, TrainName="百福",Mileage=8.70, LineGroup=0},
new StationMileage(){ TrainId=1031, TrainName="汐科",Mileage=14.60, LineGroup=0},
new StationMileage(){ TrainId=1032, TrainName="浮洲",Mileage=38.00, LineGroup=0},
new StationMileage(){ TrainId=1033, TrainName="北湖",Mileage=87.10, LineGroup=0},
new StationMileage(){ TrainId=1102, TrainName="談文",Mileage=4.50, LineGroup=1},
new StationMileage(){ TrainId=1104, TrainName="大山",Mileage=11.20, LineGroup=1},
new StationMileage(){ TrainId=1105, TrainName="後龍",Mileage=15.00, LineGroup=1},
new StationMileage(){ TrainId=1106, TrainName="龍港",Mileage=18.60, LineGroup=1},
new StationMileage(){ TrainId=1107, TrainName="白沙屯",Mileage=26.70, LineGroup=1},
new StationMileage(){ TrainId=1108, TrainName="新埔",Mileage=29.80, LineGroup=1},
new StationMileage(){ TrainId=1109, TrainName="通霄",Mileage=35.60, LineGroup=1},
new StationMileage(){ TrainId=1110, TrainName="苑裡",Mileage=41.70, LineGroup=1},
new StationMileage(){ TrainId=1111, TrainName="日南",Mileage=49.40, LineGroup=1},
new StationMileage(){ TrainId=1112, TrainName="大甲",Mileage=54.00, LineGroup=1},
new StationMileage(){ TrainId=1113, TrainName="台中港",Mileage=59.30, LineGroup=1},
new StationMileage(){ TrainId=1114, TrainName="清水",Mileage=65.30, LineGroup=1},
new StationMileage(){ TrainId=1115, TrainName="沙鹿",Mileage=68.50, LineGroup=1},
new StationMileage(){ TrainId=1116, TrainName="龍井",Mileage=73.10, LineGroup=1},
new StationMileage(){ TrainId=1117, TrainName="大肚",Mileage=78.10, LineGroup=1},
new StationMileage(){ TrainId=1118, TrainName="追分",Mileage=83.10, LineGroup=1},
new StationMileage(){ TrainId=1118, TrainName="追分",Mileage=2.20, LineGroup=7},
new StationMileage(){ TrainId=1120, TrainName="彰化",Mileage=210.90, LineGroup=0},
new StationMileage(){ TrainId=1120, TrainName="彰化",Mileage=90.20, LineGroup=1},
new StationMileage(){ TrainId=1202, TrainName="花壇",Mileage=217.50, LineGroup=0},
new StationMileage(){ TrainId=1203, TrainName="員林",Mileage=225.60, LineGroup=0},
new StationMileage(){ TrainId=1204, TrainName="永靖",Mileage=229.10, LineGroup=0},
new StationMileage(){ TrainId=1205, TrainName="社頭",Mileage=232.80, LineGroup=0},
new StationMileage(){ TrainId=1206, TrainName="田中",Mileage=237.10, LineGroup=0},
new StationMileage(){ TrainId=1207, TrainName="二水",Mileage=242.90, LineGroup=0},
new StationMileage(){ TrainId=1207, TrainName="二水",Mileage=0.00, LineGroup=6},
new StationMileage(){ TrainId=1208, TrainName="林內",Mileage=251.00, LineGroup=0},
new StationMileage(){ TrainId=1209, TrainName="石榴",Mileage=255.80, LineGroup=0},
new StationMileage(){ TrainId=1210, TrainName="斗六",Mileage=260.60, LineGroup=0},
new StationMileage(){ TrainId=1211, TrainName="斗南",Mileage=268.20, LineGroup=0},
new StationMileage(){ TrainId=1212, TrainName="石龜",Mileage=272.10, LineGroup=0},
new StationMileage(){ TrainId=1213, TrainName="大林",Mileage=276.70, LineGroup=0},
new StationMileage(){ TrainId=1214, TrainName="民雄",Mileage=282.50, LineGroup=0},
new StationMileage(){ TrainId=1215, TrainName="嘉義",Mileage=291.80, LineGroup=0},
new StationMileage(){ TrainId=1217, TrainName="水上",Mileage=298.40, LineGroup=0},
new StationMileage(){ TrainId=1218, TrainName="南靖",Mileage=301.00, LineGroup=0},
new StationMileage(){ TrainId=1219, TrainName="後壁",Mileage=307.00, LineGroup=0},
new StationMileage(){ TrainId=1220, TrainName="新營",Mileage=314.70, LineGroup=0},
new StationMileage(){ TrainId=1221, TrainName="柳營",Mileage=318.00, LineGroup=0},
new StationMileage(){ TrainId=1222, TrainName="林鳳營",Mileage=321.90, LineGroup=0},
new StationMileage(){ TrainId=1223, TrainName="隆田",Mileage=327.40, LineGroup=0},
new StationMileage(){ TrainId=1224, TrainName="拔林",Mileage=329.60, LineGroup=0},
new StationMileage(){ TrainId=1225, TrainName="善化",Mileage=334.20, LineGroup=0},
new StationMileage(){ TrainId=1226, TrainName="新市",Mileage=341.80, LineGroup=0},
new StationMileage(){ TrainId=1227, TrainName="永康",Mileage=346.80, LineGroup=0},
new StationMileage(){ TrainId=1228, TrainName="台南",Mileage=353.20, LineGroup=0},
new StationMileage(){ TrainId=1229, TrainName="保安",Mileage=360.80, LineGroup=0},
new StationMileage(){ TrainId=1230, TrainName="中洲",Mileage=364.80, LineGroup=0},
new StationMileage(){ TrainId=1230, TrainName="中洲",Mileage=0.00, LineGroup=8},
new StationMileage(){ TrainId=1231, TrainName="大湖",Mileage=367.70, LineGroup=0},
new StationMileage(){ TrainId=1232, TrainName="路竹",Mileage=370.60, LineGroup=0},
new StationMileage(){ TrainId=1233, TrainName="岡山",Mileage=378.40, LineGroup=0},
new StationMileage(){ TrainId=1234, TrainName="橋頭",Mileage=382.00, LineGroup=0},
new StationMileage(){ TrainId=1235, TrainName="楠梓",Mileage=386.20, LineGroup=0},
new StationMileage(){ TrainId=1236, TrainName="左營",Mileage=393.20, LineGroup=0},
new StationMileage(){ TrainId=1238, TrainName="高雄",Mileage=399.80, LineGroup=0},
new StationMileage(){ TrainId=1239, TrainName="大橋",Mileage=350.50, LineGroup=0},
new StationMileage(){ TrainId=1240, TrainName="大村",Mileage=222.10, LineGroup=0},
new StationMileage(){ TrainId=1241, TrainName="嘉北",Mileage=289.20, LineGroup=0},
new StationMileage(){ TrainId=1242, TrainName="新左營",Mileage=391.30, LineGroup=0},
new StationMileage(){ TrainId=1244, TrainName="南科",Mileage=337.10, LineGroup=0},
new StationMileage(){ TrainId=1302, TrainName="造橋",Mileage=130.70, LineGroup=0},
new StationMileage(){ TrainId=1304, TrainName="豐富",Mileage=137.10, LineGroup=0},
new StationMileage(){ TrainId=1305, TrainName="苗栗",Mileage=140.60, LineGroup=0},
new StationMileage(){ TrainId=1307, TrainName="南勢",Mileage=147.20, LineGroup=0},
new StationMileage(){ TrainId=1308, TrainName="銅鑼",Mileage=151.40, LineGroup=0},
new StationMileage(){ TrainId=1310, TrainName="三義",Mileage=158.80, LineGroup=0},
new StationMileage(){ TrainId=1314, TrainName="泰安",Mileage=169.70, LineGroup=0},
new StationMileage(){ TrainId=1315, TrainName="后里",Mileage=172.30, LineGroup=0},
new StationMileage(){ TrainId=1317, TrainName="豐原",Mileage=179.10, LineGroup=0},
new StationMileage(){ TrainId=1318, TrainName="潭子",Mileage=184.10, LineGroup=0},
new StationMileage(){ TrainId=1319, TrainName="台中",Mileage=193.30, LineGroup=0},
new StationMileage(){ TrainId=1320, TrainName="烏日",Mileage=200.50, LineGroup=0},
new StationMileage(){ TrainId=1321, TrainName="成功",Mileage=203.80, LineGroup=0},
new StationMileage(){ TrainId=1321, TrainName="成功",Mileage=0.00, LineGroup=7},
new StationMileage(){ TrainId=1322, TrainName="大慶",Mileage=197.50, LineGroup=0},
new StationMileage(){ TrainId=1323, TrainName="太原",Mileage=189.20, LineGroup=0},
new StationMileage(){ TrainId=1324, TrainName="新烏日",Mileage=201.30, LineGroup=0},
new StationMileage(){ TrainId=1402, TrainName="鳳山",Mileage=405.60, LineGroup=0},
new StationMileage(){ TrainId=1403, TrainName="後庄",Mileage=409.30, LineGroup=0},
new StationMileage(){ TrainId=1404, TrainName="九曲堂",Mileage=413.60, LineGroup=0},
new StationMileage(){ TrainId=1405, TrainName="六塊厝",Mileage=418.60, LineGroup=0},
new StationMileage(){ TrainId=1406, TrainName="屏東",Mileage=420.80, LineGroup=0},
new StationMileage(){ TrainId=1406, TrainName="屏東",Mileage=0.00, LineGroup=3},
new StationMileage(){ TrainId=1407, TrainName="歸來",Mileage=2.60, LineGroup=3},
new StationMileage(){ TrainId=1408, TrainName="麟洛",Mileage=4.90, LineGroup=3},
new StationMileage(){ TrainId=1409, TrainName="西勢",Mileage=7.30, LineGroup=3},
new StationMileage(){ TrainId=1410, TrainName="竹田",Mileage=11.00, LineGroup=3},
new StationMileage(){ TrainId=1411, TrainName="潮州",Mileage=15.10, LineGroup=3},
new StationMileage(){ TrainId=1412, TrainName="崁頂",Mileage=19.90, LineGroup=3},
new StationMileage(){ TrainId=1413, TrainName="南州",Mileage=22.30, LineGroup=3},
new StationMileage(){ TrainId=1414, TrainName="鎮安",Mileage=25.90, LineGroup=3},
new StationMileage(){ TrainId=1415, TrainName="林邊",Mileage=29.10, LineGroup=3},
new StationMileage(){ TrainId=1416, TrainName="佳冬",Mileage=33.10, LineGroup=3},
new StationMileage(){ TrainId=1417, TrainName="東海",Mileage=36.20, LineGroup=3},
new StationMileage(){ TrainId=1418, TrainName="枋寮",Mileage=40.30, LineGroup=3},
new StationMileage(){ TrainId=1502, TrainName="加祿",Mileage=45.60, LineGroup=3},
new StationMileage(){ TrainId=1503, TrainName="內獅",Mileage=49.00, LineGroup=3},
new StationMileage(){ TrainId=1504, TrainName="枋山",Mileage=53.90, LineGroup=3},
new StationMileage(){ TrainId=1507, TrainName="古莊",Mileage=80.80, LineGroup=3},
new StationMileage(){ TrainId=1508, TrainName="大武",Mileage=84.10, LineGroup=3},
new StationMileage(){ TrainId=1510, TrainName="瀧溪",Mileage=95.80, LineGroup=3},
new StationMileage(){ TrainId=1512, TrainName="金崙",Mileage=104.20, LineGroup=3},
new StationMileage(){ TrainId=1514, TrainName="太麻里",Mileage=115.20, LineGroup=3},
new StationMileage(){ TrainId=1516, TrainName="知本",Mileage=126.90, LineGroup=3},
new StationMileage(){ TrainId=1517, TrainName="康樂",Mileage=133.90, LineGroup=3},
new StationMileage(){ TrainId=1602, TrainName="吉安",Mileage=172.80, LineGroup=2},
new StationMileage(){ TrainId=1604, TrainName="志學",Mileage=181.80, LineGroup=2},
new StationMileage(){ TrainId=1605, TrainName="平和",Mileage=184.70, LineGroup=2},
new StationMileage(){ TrainId=1606, TrainName="壽豐",Mileage=186.60, LineGroup=2},
new StationMileage(){ TrainId=1607, TrainName="豐田",Mileage=189.30, LineGroup=2},
new StationMileage(){ TrainId=1608, TrainName="溪口",Mileage=193.40, LineGroup=2},
new StationMileage(){ TrainId=1609, TrainName="南平",Mileage=197.80, LineGroup=2},
new StationMileage(){ TrainId=1610, TrainName="鳳林",Mileage=201.90, LineGroup=2},
new StationMileage(){ TrainId=1611, TrainName="萬榮",Mileage=206.70, LineGroup=2},
new StationMileage(){ TrainId=1612, TrainName="光復",Mileage=212.30, LineGroup=2},
new StationMileage(){ TrainId=1613, TrainName="大富",Mileage=220.00, LineGroup=2},
new StationMileage(){ TrainId=1614, TrainName="富源",Mileage=223.00, LineGroup=2},
new StationMileage(){ TrainId=1616, TrainName="瑞穗",Mileage=232.30, LineGroup=2},
new StationMileage(){ TrainId=1617, TrainName="三民",Mileage=241.50, LineGroup=2},
new StationMileage(){ TrainId=1619, TrainName="玉里",Mileage=252.50, LineGroup=2},
new StationMileage(){ TrainId=1621, TrainName="東里",Mileage=259.20, LineGroup=2},
new StationMileage(){ TrainId=1622, TrainName="東竹",Mileage=265.10, LineGroup=2},
new StationMileage(){ TrainId=1623, TrainName="富里",Mileage=271.30, LineGroup=2},
new StationMileage(){ TrainId=1624, TrainName="池上",Mileage=278.20, LineGroup=2},
new StationMileage(){ TrainId=1625, TrainName="海端",Mileage=283.80, LineGroup=2},
new StationMileage(){ TrainId=1626, TrainName="關山",Mileage=290.30, LineGroup=2},
new StationMileage(){ TrainId=1628, TrainName="瑞和",Mileage=297.70, LineGroup=2},
new StationMileage(){ TrainId=1629, TrainName="瑞源",Mileage=300.50, LineGroup=2},
new StationMileage(){ TrainId=1630, TrainName="鹿野",Mileage=306.00, LineGroup=2},
new StationMileage(){ TrainId=1631, TrainName="山里",Mileage=312.20, LineGroup=2},
new StationMileage(){ TrainId=1632, TrainName="台東",Mileage=320.30, LineGroup=2},
new StationMileage(){ TrainId=1632, TrainName="台東",Mileage=138.50, LineGroup=3},
new StationMileage(){ TrainId=1703, TrainName="永樂",Mileage=95.40, LineGroup=2},
new StationMileage(){ TrainId=1704, TrainName="東澳",Mileage=101.20, LineGroup=2},
new StationMileage(){ TrainId=1705, TrainName="南澳",Mileage=109.20, LineGroup=2},
new StationMileage(){ TrainId=1706, TrainName="武塔",Mileage=112.90, LineGroup=2},
new StationMileage(){ TrainId=1708, TrainName="漢本",Mileage=125.80, LineGroup=2},
new StationMileage(){ TrainId=1709, TrainName="和平",Mileage=130.00, LineGroup=2},
new StationMileage(){ TrainId=1710, TrainName="和仁",Mileage=137.70, LineGroup=2},
new StationMileage(){ TrainId=1711, TrainName="崇德",Mileage=147.80, LineGroup=2},
new StationMileage(){ TrainId=1712, TrainName="新城",Mileage=153.10, LineGroup=2},
new StationMileage(){ TrainId=1713, TrainName="景美",Mileage=158.40, LineGroup=2},
new StationMileage(){ TrainId=1714, TrainName="北埔",Mileage=164.90, LineGroup=2},
new StationMileage(){ TrainId=1715, TrainName="花蓮",Mileage=169.40, LineGroup=2},
new StationMileage(){ TrainId=1802, TrainName="暖暖",Mileage=1.60, LineGroup=2},
new StationMileage(){ TrainId=1803, TrainName="四腳亭",Mileage=3.90, LineGroup=2},
new StationMileage(){ TrainId=1804, TrainName="瑞芳",Mileage=8.90, LineGroup=2},
new StationMileage(){ TrainId=1804, TrainName="瑞芳",Mileage=0.00, LineGroup=10},
new StationMileage(){ TrainId=1805, TrainName="侯硐",Mileage=13.50, LineGroup=2},
new StationMileage(){ TrainId=1806, TrainName="三貂嶺",Mileage=16.00, LineGroup=2},
new StationMileage(){ TrainId=1806, TrainName="三貂嶺",Mileage=0.00, LineGroup=4},
new StationMileage(){ TrainId=1807, TrainName="牡丹",Mileage=19.60, LineGroup=2},
new StationMileage(){ TrainId=1808, TrainName="雙溪",Mileage=22.90, LineGroup=2},
new StationMileage(){ TrainId=1809, TrainName="貢寮",Mileage=28.30, LineGroup=2},
new StationMileage(){ TrainId=1810, TrainName="福隆",Mileage=32.00, LineGroup=2},
new StationMileage(){ TrainId=1811, TrainName="石城",Mileage=37.40, LineGroup=2},
new StationMileage(){ TrainId=1812, TrainName="大里",Mileage=40.10, LineGroup=2},
new StationMileage(){ TrainId=1813, TrainName="大溪",Mileage=44.80, LineGroup=2},
new StationMileage(){ TrainId=1814, TrainName="龜山",Mileage=49.40, LineGroup=2},
new StationMileage(){ TrainId=1815, TrainName="外澳",Mileage=53.00, LineGroup=2},
new StationMileage(){ TrainId=1816, TrainName="頭城",Mileage=56.60, LineGroup=2},
new StationMileage(){ TrainId=1817, TrainName="頂埔",Mileage=58.80, LineGroup=2},
new StationMileage(){ TrainId=1818, TrainName="礁溪",Mileage=62.90, LineGroup=2},
new StationMileage(){ TrainId=1819, TrainName="四城",Mileage=67.60, LineGroup=2},
new StationMileage(){ TrainId=1820, TrainName="宜蘭",Mileage=71.30, LineGroup=2},
new StationMileage(){ TrainId=1821, TrainName="二結",Mileage=77.10, LineGroup=2},
new StationMileage(){ TrainId=1822, TrainName="中里",Mileage=78.30, LineGroup=2},
new StationMileage(){ TrainId=1823, TrainName="羅東",Mileage=80.10, LineGroup=2},
new StationMileage(){ TrainId=1824, TrainName="冬山",Mileage=85.10, LineGroup=2},
new StationMileage(){ TrainId=1825, TrainName="新馬",Mileage=89.30, LineGroup=2},
new StationMileage(){ TrainId=1826, TrainName="蘇澳新",Mileage=90.20, LineGroup=2},
new StationMileage(){ TrainId=1827, TrainName="蘇澳",Mileage=93.60, LineGroup=2},
new StationMileage(){ TrainId=1903, TrainName="大華",Mileage=3.50, LineGroup=4},
new StationMileage(){ TrainId=1904, TrainName="十分",Mileage=6.40, LineGroup=4},
new StationMileage(){ TrainId=1905, TrainName="望古",Mileage=8.20, LineGroup=4},
new StationMileage(){ TrainId=1906, TrainName="嶺腳",Mileage=10.20, LineGroup=4},
new StationMileage(){ TrainId=1907, TrainName="平溪",Mileage=11.20, LineGroup=4},
new StationMileage(){ TrainId=1908, TrainName="菁桐",Mileage=12.90, LineGroup=4},
new StationMileage(){ TrainId=2203, TrainName="竹中",Mileage=7.90, LineGroup=5},
new StationMileage(){ TrainId=2203, TrainName="竹中",Mileage=0.00, LineGroup=9},
new StationMileage(){ TrainId=2204, TrainName="上員",Mileage=10.50, LineGroup=5},
new StationMileage(){ TrainId=2205, TrainName="竹東",Mileage=16.60, LineGroup=5},
new StationMileage(){ TrainId=2206, TrainName="橫山",Mileage=20.00, LineGroup=5},
new StationMileage(){ TrainId=2207, TrainName="九讚頭",Mileage=22.20, LineGroup=5},
new StationMileage(){ TrainId=2208, TrainName="合興",Mileage=24.40, LineGroup=5},
new StationMileage(){ TrainId=2209, TrainName="富貴",Mileage=25.70, LineGroup=5},
new StationMileage(){ TrainId=2210, TrainName="內灣",Mileage=27.90, LineGroup=5},
new StationMileage(){ TrainId=2211, TrainName="榮華",Mileage=15.00, LineGroup=5},
new StationMileage(){ TrainId=2212, TrainName="千甲",Mileage=3.60, LineGroup=5},
new StationMileage(){ TrainId=2213, TrainName="新莊",Mileage=6.60, LineGroup=5},
new StationMileage(){ TrainId=2214, TrainName="六家",Mileage=3.10, LineGroup=9},
new StationMileage(){ TrainId=2702, TrainName="源泉",Mileage=2.90, LineGroup=6},
new StationMileage(){ TrainId=2703, TrainName="濁水",Mileage=10.80, LineGroup=6},
new StationMileage(){ TrainId=2704, TrainName="龍泉",Mileage=15.70, LineGroup=6},
new StationMileage(){ TrainId=2705, TrainName="集集",Mileage=20.10, LineGroup=6},
new StationMileage(){ TrainId=2706, TrainName="水里",Mileage=27.40, LineGroup=6},
new StationMileage(){ TrainId=2707, TrainName="車埕",Mileage=29.70, LineGroup=6},
new StationMileage(){ TrainId=5101, TrainName="長榮大學",Mileage=2.60, LineGroup=8},
new StationMileage(){ TrainId=5102, TrainName="沙崙",Mileage=5.30, LineGroup=8},
        };
        #endregion

        private List<int> StationCrosses
        {
            get
            {
                return (from m in StationMileages
                        group m by m.TrainId into grp
                        where grp.Count() > 1
                        select grp.Key).ToList();
            }
             
        }


        [TestMethod]
        public void TestGetCalcMileage()
        {
            MileageCalc MileageCalc = new MileageCalc();
            double expected = 11.7; // TODO: 初始化為適當值
            double actual = MileageCalc.GetCalcMileage(StationMileages, StationCrosses, 1001, 1004);
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }

        [TestMethod]
        public void TestGetCalcMileage2()
        {
            MileageCalc MileageCalc = new MileageCalc();
            double expected = 5.3; // TODO: 初始化為適當值
            double actual = MileageCalc.GetCalcMileage(StationMileages, StationCrosses, 1001, 1802);
            Assert.AreEqual(expected, Math.Round(actual,2));
        }




        [TestMethod]
        public void TestGetCalcMileage3()
        {
            MileageCalc MileageCalc = new MileageCalc();
            double expected = 306.1; // TODO: 初始化為適當值
            double actual = MileageCalc.GetCalcMileage(StationMileages, StationCrosses, 1715, 1105);
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }
        [TestMethod]
        public void TestGetCalcMileage4()
        {
            MileageCalc MileageCalc = new MileageCalc();
            double expected = 15.0; // TODO: 初始化為適當值
            double actual = MileageCalc.GetCalcMileage(StationMileages, StationCrosses, 1028, 1105);
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }
        [TestMethod]
        public void TestGetCalcMileage5()
        {
            MileageCalc MileageCalc = new MileageCalc();
            double expected = 121.7; // TODO: 初始化為適當值
            double actual = MileageCalc.GetCalcMileage(StationMileages, StationCrosses, 1002, 1028);
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }
        [TestMethod]
        public void TestGetCalcMileage6()
        {
            MileageCalc MileageCalc = new MileageCalc();
            double expected = 136.7; // TODO: 初始化為適當值
            double actual = MileageCalc.GetCalcMileage(StationMileages, StationCrosses, 1002, 1105);
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }
        [TestMethod]
        public void TestGetCalcMileage7()
        {
            MileageCalc MileageCalc = new MileageCalc();
            double expected = 169.4; // TODO: 初始化為適當值
            double actual = MileageCalc.GetCalcMileage(StationMileages, StationCrosses, 1715, 1002);
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }


        //[TestMethod]
        //public void TestGetCalcMileageLoop()
        //{
        //    var sss = (from m in StationMileages
        //             group m by m.TrainId into grp
        //             select grp.Key).ToList();
        //    MileageCalc MileageCalc = new MileageCalc();
        //    foreach (var s in sss)
        //    {
        //        foreach (var s2 in sss)
        //        {
        //            var tt=MileageCalc.GetCalcMileage(StationMileages, StationCrosses, s, s2);
        //        }
        //    }


        //    //MileageCalc MileageCalc = new MileageCalc();
        //    //double expected = 169.4; // TODO: 初始化為適當值
        //    //double actual = MileageCalc.GetCalcMileage(StationMileages, StationCrosses, 1715, 1002);
        //    //Assert.AreEqual(expected, Math.Round(actual, 2));
        //}
    }
}

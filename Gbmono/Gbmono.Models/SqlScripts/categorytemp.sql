CREATE table CategoryTemp
 (  
  CategoryId int not null, 
  CategoryCode varchar(2) not null, 
  ParentId int null,
  CategoryName nvarchar(100) not null
 )

insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 1,'01',NULL,'ҽҩƷ?ҽҩ����Ʒ���䥯�ҥ󥤥䥯�֥����ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 2,'01',1,'����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 3,'01',2,'�ָ�ƣ�������ϥҥ��������ե�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 4,'02',2,'�������ϥӥ襦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 5,'02',1,'ά����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 6,'01',5,'ά������������?�۷�?�������������������ʥ�����奦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 7,'03',1,'��ð����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 8,'01',7,'������ʹҩ���ͥĥ���ĥ�����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 9,'02',7,'�ۺϸ�ðҩ��������������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 10,'03',7,'ֹ�ȥ�����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 11,'04',1,'����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 12,'01',11,'���ֹ���?����ҩ�襦�����ӥ��󥯥���')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 13,'05',1,'��θҩ�����祦�䥯')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 14,'01',13,'��θҩ�����祦�䥯')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 15,'02',13,'����ҩ�������祦����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 16,'03',13,'ֹкҩ������䥯')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 17,'06',1,'��ҩˮ�ᥰ����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 18,'01',17,'��ҩ�ᥰ����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 19,'02',17,'ϴ��ҩ���󥬥�䥯')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 20,'07',1,'����ҩ�����襦�䥯')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 21,'01',20,'����������ʹ�������襦���祦�������ĥ�����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 22,'02',20,'Ƥ��������ҩ�ҥե��å���襦�䥯')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 23,'03',20,'�̴���ҩ�����å���襦�䥯')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 24,'08',1,'���������⥦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 25,'01',24,'�����������⥦����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 26,'09',1,'Ů��?�����ե��󥫥�ݥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 27,'01',26,'Ů����ҩ�ե���襦�䥯')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 28,'02',26,'����ҩ����ݥ��䥯')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 29,'10',1,'������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 30,'01',29,'����ҽҩƷ?ҽҩ����Ʒ�ۥ����䥯�ҥ󥤥䥯�֥����ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 31,'02',NULL,'ҽ���þߥ���祦�襦��')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 32,'01',31,'����?�˿����Х󥽥�����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 33,'01',32,'��ð������Ʒ�襦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 34,'02',32,'�˿ڻ�����Ʒ�襦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 35,'02',31,'�羱׵��������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 36,'01',35,'����?������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 37,'02',35,'�����ʹ������Ʒ�襦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 38,'03',31,'����������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 39,'01',38,'�ⶨ���ߥ����ƥ�����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 40,'04',31,'������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 41,'01',40,'��̥������Ʒ���奿�����祦�����襦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 42,'05',31,'������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 43,'01',42,'����ҽ���þߥۥ�����祦�襦��')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 44,'03',NULL,'����ʳƷ���󥳥����祯�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 45,'01',44,'����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 46,'01',45,'����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 47,'02',45,'���إ�����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 48,'03',45,'���ݥӥ襦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 49,'02',44,'ά����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 50,'01',49,'ά����?������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 51,'03',44,'�����᥵��')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 52,'01',51,'������?�����ʥ���')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 53,'02',51,'��֭?������?С���奢������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 54,'04',44,'����ʳƷ���Υ����祯�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 55,'01',54,'���໤�������Ƹ��������⥤�󥷥�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 56,'02',54,'DHA?EPA')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 57,'03',54,'������?�����ǰ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 58,'04',54,'�۾������ҥȥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 59,'05',44,'��?��ȡ�����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 60,'01',59,'������?�����ץ��󥳥����㥱�󥳥���')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 61,'02',59,'��ȡ������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 62,'06',44,'����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 63,'01',62,'��������ʳƷ�ۥ����󥳥����祯�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 64,'04',NULL,'������ױƷ���������祦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 65,'01',64,'������ױ�७�������祦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 66,'01',65,'���楻�󥬥��祦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 67,'02',65,'жױ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 68,'03',65,'��ױˮ�����祦����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 69,'04',65,'��Һ?����Һ�˥奦�����ӥ襦����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 70,'02',64,'��Ĥ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 71,'01',70,'��Ĥ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 72,'02',70,'�ֲ�����?���⻤��')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 73,'03',70,'���������ۥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 74,'05',NULL,'���ױ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 75,'01',74,'���ױ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 76,'01',75,'�۵�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 77,'02',75,'���˪?��覸ॷ����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 78,'03',75,'ɢ��')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 79,'04',75,'�������ױ�ۥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 80,'06',NULL,'�ֲ�ױ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 81,'01',80,'�۲��ҥȥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 82,'01',81,'üˢ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 83,'02',81,'����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 84,'03',81,'��ë��')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 85,'04',81,'��Ӱ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 86,'02',80,'��������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 87,'01',86,'�ں�?���ʥ����٥�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 88,'02',86,'����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 89,'03',86,'ָ����?����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 90,'04',86,'�����ֲ�ױ�ۥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 91,'07',NULL,'һ�㻯ױƷ���åѥ󥱥��祦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 92,'01',91,'����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 93,'01',92,'���廤��')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 94,'02',92,'��˪')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 95,'03',92,'������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 96,'02',91,'��ɹ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 97,'01',96,'��ɹ�������������襦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 98,'02',96,'��ɹ�����壩�襦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 99,'03',91,'���ǣ���ۣ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 100,'01',99,'���ǣ���ۣ���Ʒ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 101,'02',99,'��ë?��ë����⥦���ĥ⥦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 102,'03',99,'�Ȳ�����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 103,'04',99,'������?�����������७�Υ�����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 104,'05',99,'��ױ��Ʒ�����祦�����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 105,'04',91,'���ݵ����ӥ襦���ǥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 106,'01',105,'���ݼҵ�ӥ襦���ǥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 107,'05',91,'��ˮ��������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 108,'01',107,'��ˮ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 109,'06',91,'������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 110,'01',109,'������ױƷ�ۥ������祦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 111,'08',NULL,'ͷ������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 112,'01',111,'ϴ��ˮ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 113,'01',112,'ϴ��ˮ?������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 114,'02',111,'����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 115,'01',114,'������?����Ĥ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 116,'02',114,'�޸�?��ϴ������ۥ��奦����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 117,'03',111,'ͷƤ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 118,'01',117,'ͷƤ����?���������⥦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 119,'09',NULL,'Ⱦ��')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 120,'01',119,'Ⱦ��')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 121,'01',120,'ʱ��Ⱦ������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 122,'02',120,'Ⱦ�׷����饬����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 123,'03',120,'�̷�Һ����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 124,'10',NULL,'ͷ������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 125,'01',124,'ͷ������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 126,'01',125,'���ͥͥʥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 127,'02',125,'����������?�緢ˮ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 128,'03',125,'����?����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 129,'04',125,'���ˮ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 130,'05',125,'����Ħ˿')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 131,'06',125,'����������Ʒ�ۥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 132,'11',NULL,'��ԡ?�����˥奦�襯���å���')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 133,'01',132,'Һ�奨������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 134,'01',133,'��ԡ¶')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 135,'02',132,'���女����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 136,'01',135,'����������������å���')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 137,'03',132,'��˪')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 138,'01',137,'ϴ��Һ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 139,'04',132,'��ԡ���˥奦�襯����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 140,'01',139,'��ԡ�����Σ��˥奦�襯����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 141,'12',NULL,'��ǻ����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 142,'01',141,'����ϥߥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 143,'01',142,'����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 144,'02',141,'��ˢ��')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 145,'01',144,'��ˢ?����ˢ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 146,'02',144,'�綯��ˢ�ǥ�ɥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 147,'03',141,'��ǻ����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 148,'01',147,'����ˮ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 149,'02',147,'�ڳ������������奦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 150,'04',141,'�׶����ɥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 151,'01',150,'�׶����ॳ�ɥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 152,'02',150,'�׶���ˢ���ɥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 153,'05',141,'������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 154,'01',153,'������ǻ�����ۥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 155,'13',NULL,'Ů����Ʒ���祻���襦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 156,'01',155,'ֽ��')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 157,'01',156,'������������襦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 158,'02',155,'����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 159,'01',158,'����������������襦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 160,'03',155,'����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 161,'01',160,'�����û���')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 162,'04',155,'������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 163,'01',162,'��΢ʧ���������å���')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 164,'02',162,'����Ů����Ʒ�ۥ����祻���襦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 165,'14',NULL,'Ӥͯ��Ʒ�襦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 166,'01',165,'ֽ�򲼥���')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 167,'01',166,'ֽ��㥫��')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 168,'02',166,'ֽ��㣨�����㣩����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 169,'02',165,'ʳƷ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 170,'01',169,'Ӥ���̷�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 171,'02',169,'Ӥ��ʳƷ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 172,'03',165,'����Ʒ�襦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 173,'01',172,'Ӥ��ʪ��ֽ�����襦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 174,'02',172,'Ӥ����Ʒ�襦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 175,'15',NULL,'���Ի�ױƷ���󥻥������祦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 176,'01',175,'���Ի�ױƷ�����祦')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 177,'01',176,'���楻�󥬥�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 178,'02',176,'������ױƷ���������祦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 179,'03',176,'���ǣ���ۣ���Ʒ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 180,'02',175,'���뵶')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 181,'01',180,'�������뵶���󥻥�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 182,'02',180,'������Ʒ�襦�ҥ�')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 183,'03',175,'����ͷ������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 184,'01',183,'ϴ��ˮ?������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 185,'02',183,'ͷƤ����?����')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 186,'03',183,'������Ʒ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 187,'04',175,'����������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 188,'01',187,'��ɹ')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 189,'02',187,'������')
insert categorytemp (CategoryId,CategoryCode,ParentId,CategoryName)  values ( 190,'03',187,'�������Ի�ױƷ�ۥ����󥻥������祦�ҥ�')
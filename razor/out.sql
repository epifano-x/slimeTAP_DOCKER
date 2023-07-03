BEGIN TRANSACTION;
CREATE TABLE "Usuario" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Usuario" PRIMARY KEY AUTOINCREMENT,
    "UsuarioNome" TEXT NOT NULL,
    "Senha" TEXT NOT NULL,
    "Email" TEXT NULL,
    "Moeda" REAL NULL,
    "MoedaTotal" REAL NULL,
    "Level" INTEGER NOT NULL,
    "Xp" INTEGER NOT NULL,
    "Nivel" INTEGER NOT NULL,
    "Diamante" INTEGER NULL,
    "Gema" INTEGER NULL,
    "Multiplicador" REAL NULL,
    "Upgrade1" INTEGER NULL,
    "Upgrade2" INTEGER NULL,
    "Upgrade3" INTEGER NULL,
    "Upgrade4" INTEGER NULL,
    "Upgrade5" INTEGER NULL,
    "Upgrade6" INTEGER NULL,
    "Upgrade7" INTEGER NULL,
    "Upgrade8" INTEGER NULL,
    "Upgrade9" INTEGER NULL,
    "Upgrade10" INTEGER NULL,
    "Upgrade11" INTEGER NULL
);
INSERT INTO "Usuario" VALUES(1,'asd','asd','asd',36.0,36.0,40,40,25,80,17,1.0,1,1,1,1,1,1,1,1,1,294,108);
INSERT INTO "Usuario" VALUES(2,'aaa','aaa','aaa',0.0,150.0,1,0,0,100,100,1.0,1,1,1,1,1,1,1,1,1,1,1);
INSERT INTO "Usuario" VALUES(3,'will','will','will',0.0,1000.0,1,1000,0,100,100,1.0,1,1,1,1,1,1,1,1,1,1,1);
INSERT INTO "Usuario" VALUES(4,'1','1','1',0.0,0.0,1,0,0,100,100,1.0,1,1,1,1,1,1,1,1,1,1,1);
INSERT INTO "Usuario" VALUES(5,'qwe','qwe','qwe',0.0,0.0,1,0,0,100,100,1.0,1,1,1,1,1,1,1,1,1,1,1);
INSERT INTO "Usuario" VALUES(6,'ert','ert','ert',0.0,0.0,1,0,0,100,100,1.0,1,1,1,1,1,1,1,1,1,1,1);
INSERT INTO "Usuario" VALUES(7,'ccc','ccc','ccc',0.0,0.0,1,0,0,100,100,1.0,1,1,1,1,1,1,1,1,1,1,1);
INSERT INTO "Usuario" VALUES(8,'777','777','777',0.0,0.0,1,0,0,100,100,1.0,1,1,1,1,1,1,1,1,1,1,1);
INSERT INTO "Usuario" VALUES(9,'dsad','dsa','dasd',0.0,0.0,1,0,0,100,100,1.0,1,1,1,1,1,1,1,1,1,1,1);
CREATE TABLE "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);
INSERT INTO "__EFMigrationsHistory" VALUES('20230625105843_InitialCreate','7.0.8');
DELETE FROM "sqlite_sequence";
INSERT INTO "sqlite_sequence" VALUES('Usuario',11);
COMMIT;

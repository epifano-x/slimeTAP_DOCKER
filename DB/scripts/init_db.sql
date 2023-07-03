use slime;

CREATE TABLE Usuario (
    Id INT NOT NULL AUTO_INCREMENT,
    UsuarioNome TEXT NOT NULL,
    Senha TEXT NOT NULL,
    Email TEXT,
    Moeda FLOAT,
    MoedaTotal FLOAT,
    Level INT NOT NULL,
    Xp INT NOT NULL,
    Nivel INT NOT NULL,
    Diamante INT,
    Gema INT,
    Multiplicador FLOAT,
    Upgrade1 INT,
    Upgrade2 INT,
    Upgrade3 INT,
    Upgrade4 INT,
    Upgrade5 INT,
    Upgrade6 INT,
    Upgrade7 INT,
    Upgrade8 INT,
    Upgrade9 INT,
    Upgrade10 INT,
    Upgrade11 INT,
    PRIMARY KEY (Id)
);

INSERT INTO Usuario (UsuarioNome, Senha, Email, Moeda, MoedaTotal, Level, Xp, Nivel, Diamante, Gema, Multiplicador, Upgrade1, Upgrade2, Upgrade3, Upgrade4, Upgrade5, Upgrade6, Upgrade7, Upgrade8, Upgrade9, Upgrade10, Upgrade11)
VALUES
    ('Joao', 'senha123', 'joao@email.com', 100.5, 500.75, 5, 1000, 2, 10, 5, 1.5, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3),
    ('Maria', 'senha456', 'maria@email.com', 50.25, 250.35, 3, 500, 1, 5, 2, 1.2, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4),
    ('Pedro', 'senha789', 'maria@email.com', 10.75, 100.5, 2, 250, 1, 2, 2, 1.1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2),
    ('asd', 'asd', 'asd@email.com', 10000.75, 10000.75, 2500, 2500, 10000, 20000, 20000, 1.1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2);


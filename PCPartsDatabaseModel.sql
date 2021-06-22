CREATE TABLE PowerSupply {
    name                VARCHAR(30),
    brand               VARCHAR(30),
    maxPower            INT,
    fans                INT,
    energyEfficiency    VARCHAR(30),
    weight              DECIMAL(4,2,),
    price               DECIMAL(10,2),
    PRIMARY KEY (name)
};

CREATE TABLE MotherBoard {
    name            VARCHAR(30),
    brand           VARCHAR(30),
    socket          VARCHAR(12),
    chipset         VARCHAR(25),
    memoryCap       INT,
    memoryStandard  VARCHAR(10),
    usbPorts        INT,
    PCIthree        INT,
    price           DECIMAL(10,2),
    PRIMARY KEY (name)
};

CREATE TABLE Memory {
    name        VARCHAR(30),
    brand       VARCHAR(30),
    capactiy    INT,
    speed       INT,
    timing      VARCHAR(30),
    cas         INT,
    price       DECIMAL(6,2)
};

CREATE TABLE CPU {
    name    VARCHAR(30),
    brand   VARCHAR(30),
    gen     VARCHAR(30),
    socket  VARCHAR(12),
    core    INT,
    thread  INT,
    speed   DECIMAL(2,1),
    lthree  DECIMAL(2,1),
    tdp     INT,
    price   DECIMAL(6,2),
    series  VARCHAR(12),
    turbo   DECIMAL(2,1),
    ltwo    DECIMAL(2,1),
    PRIMARY KEY(name)
};

CREATE TABLE GPU {
    gpu             VARCHAR(30),
    memory         INT,
    memoryType      VARCHAR(10),
    memoryInterface INT,
    PRIMARY KEY (gpu)
};

CREATE TABLE Monitor {

};

CREATE TABLE TowerCase {

};

CREATE TABLE SSD {

};

CREATE TABLE HDD {

};

CREATE TABLE Cooling {

};


create table "Priests"(
"PriestID" int identity (1,1) not null,
"Name" nvarchar(30) not null,
"ContactNumber" int not null,
"DOJ" date not null,
"LockerNumber" nvarchar(5) not null,
constraint "PK_Priests" primary key clustered("PriestID")
)
go

create table "Responsibilities"(
"ResponsibilityID" int identity (1,1) not null,
"Responsibility" nvarchar(70) not null,
"MinimumExperience" int not null default 0,
constraint "PK_Responsibilities" primary key clustered("ResponsibilityID")
)
go

create table "Chores"(
"SrNo" int identity (1,1) not null,
"PriestID" int,
"Resonsibilities" int,
constraint "FK_Chores_Priests" foreign key ("PriestID") references "dbo"."Priests"("PriestID"),
constraint "FK_Chores_Responsibilities" foreign key ("Resonsibilities") references "dbo"."Responsibilities"("ResponsibilityID")
)
go

create table "SweetDishesList"(
"ItemID" int identity (1,1) not null,
"DishName" nvarchar(20) not null,
"CostPerPlate" decimal not null,
constraint "SweetDishList" primary key clustered("ItemID")
)
go

create table "RiceItemsList"(
"ItemID" int identity (1,1) not null,
"DishName" nvarchar(20) not null,
"CostPerPlate" decimal not null,
constraint "RiceItemList" primary key clustered("ItemID")
)
go

create table "PrasadamDistribution"(
"SrNo" int identity (1,1) not null,
"Date" date not null,
"PriestID" int,
"SweetDishIDs" int,
"RiceItemIDs" int,
"Quantity" int not null,
constraint "FK_PrasadamDistribution_Priests" foreign key ("PriestID") references "dbo"."Priests"("PriestID"),
constraint "FK_PrasadamDistribution_SweetDishesList" foreign key ("SweetDishIDs") references "dbo"."SweetDishesList"("ItemID"),
constraint "FK_PrasadamDistribution_RiceItemsList" foreign key ("RiceItemIDs") references "dbo"."RiceItemsList"("ItemID")
)
go

create table "Expences"(
"SrNo" int identity (1,1) not null,
"Date" date not null,
"Daily" decimal default 0,
"Monthly" decimal default 0,
"Yearly" decimal default 0,
constraint "PK_Expenses" primary key clustered("SrNo")
)
go

create table "Login"(
"ID" nvarchar(20),
"Password" nvarchar(20),
constraint "PK_Login" primary key clustered("ID")
)
go
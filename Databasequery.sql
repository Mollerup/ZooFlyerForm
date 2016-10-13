
create table [Users](
Id int identity(0,1) not null primary key,
Email varchar(50) not null,
Password varchar(50) not null,
Firstname varchar(20) not null,
Lastname varchar(50) not null
);

create table [Cities](
Zipcode int not null primary key,
City varchar(50) not null,
constraint checkZip
check(Zipcode between 1000 and 9999)
); 

create table [Addresses](
Id int identity(0,1) not null primary key,
Zipcode int not null foreign key references Cities(Zipcode),
Street varchar(50) not null
);

create table [Seasons](
Id int identity(0,1) not null primary key,
Season varchar(20) not null
);

create table [Days](
Id int identity(0,1) not null primary key,
[Day] varchar(10) not null
);

create table [OpeningHours](
Id int identity(0,1) not null primary key,
Season int not null foreign key references Seasons(Id),
[Day] int not null foreign key references [Days](Id),
[Open] time(0) not null,
[Close] time(0) not null
);

create table [Prices](
Id int identity(0,1) not null primary key,
Price int not null
);

create table [Images](
ImageId int identity(0,1) not null primary key,
Pics image not null
);

create table [Flyers](
Id int identity(0,1) not null primary key,
[User] int not null foreign key references Users(Id),
OpeningHours int not null foreign key references OpeningHours(Id),
Price int not null foreign key references Prices(Id),
[Address] int not null foreign key references Addresses(Id),
Pics int not null foreign key references Images(ImageId),
);
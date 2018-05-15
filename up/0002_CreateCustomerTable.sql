create table dbo.customer_data (
        Id BIGINT IDENTITY NOT NULL,
       firstname NVARCHAR(255) null,
       lastname NVARCHAR(255) null,
       phone NVARCHAR(12) null,
       email NVARCHAR(255) null
       primary key (Id)
    )
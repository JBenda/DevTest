--- Create table products ---
CREATE TABLE [dbo].[products] (
    [id]              INT      IDENTITY     NOT NULL ,
    [product_id]      INT           NOT NULL,
    [product_name]    VARCHAR (255) NOT NULL,
    [stock_available] INT           NOT NULL,
    [created_at]      TIME (7)      DEFAULT (getdate()) NOT NULL,
    [updated_at]      TIME (7)      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([product_id] ASC)
);


GO

CREATE TRIGGER [OnUpdate]
    ON [products]
    AFTER UPDATE
    AS
    BEGIN
		UPDATE [products]
		SET [updated_at] = CURRENT_TIMESTAMP
		FROM [inserted] i
		WHERE [products].[id] = i.id
    END;
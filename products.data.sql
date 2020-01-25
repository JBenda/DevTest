SET IDENTITY_INSERT [dbo].[products] ON
INSERT INTO [dbo].[products] ([id], [product_id], [product_name], [stock_available], [created_at], [updated_at]) VALUES (1, 3, N'Brot', 20, N'14:11:19.87', N'14:11:19.87')
INSERT INTO [dbo].[products] ([id], [product_id], [product_name], [stock_available], [created_at], [updated_at]) VALUES (2, 8, N'Brötchen', 120, N'14:11:52.8', N'14:11:52.8')
INSERT INTO [dbo].[products] ([id], [product_id], [product_name], [stock_available], [created_at], [updated_at]) VALUES (3, 12, N'ApfelKuchen', 5, N'14:12:06.87', N'14:12:06.87')
SET IDENTITY_INSERT [dbo].[products] OFF

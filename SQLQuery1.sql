USE Comercio;

INSERT INTO Categorias (Nombre) VALUES ('Tecnología'), ('Hogar'), ('Ropa');
INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) VALUES
('Notebook Lenovo', 'Notebook i5 8GB RAM', 850000, 10, 1),
('Licuadora Philips', '600W, vaso de vidrio', 320000, 5, 2),
('Camisa Blanca', 'Manga larga, algodón', 180000, 15, 3);


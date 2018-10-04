CREATE TABLE company(
  company_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,
  name VARCHAR(50) NOT NULL,
  phone VARCHAR(50) NOT NULL,
  PRIMARY KEY(company_id),
  ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO company(name, phone) VALUES('Solintels Soluciones Integrales', '4587-5487');

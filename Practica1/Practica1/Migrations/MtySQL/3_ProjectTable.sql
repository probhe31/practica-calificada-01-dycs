CREATE TABLE project(
  project_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,
  name VARCHAR(50) NOT NULL,
  budget DECIMAL(10,2) NOT NULL,
  currency VARCHAR(3) NOT NULL,
  company_id BIGINT UNSIGNED NOT NULL,
  PRIMARY KEY(project_id),
  INDEX IX_user_id(user_id),
  CONSTRAINT FK_project_company_id FOREIGN KEY(company_id) REFERENCES company(company_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO user(name, budget, currency, company_id) VALUES('Juegos panamericanos', '350000.00', 'USD', 1);
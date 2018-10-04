CREATE TABLE user(
  user_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,
  first_name VARCHAR(50) NOT NULL,
  last_name VARCHAR(50) NOT NULL,
  phone_name VARCHAR(50) NOT NULL,
  company_id BIGINT UNSIGNED NOT NULL,
  PRIMARY KEY(user_id),
  INDEX IX_user_id(user_id),
  CONSTRAINT FK_user_company_id FOREIGN KEY(company_id) REFERENCES company(company_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO user(first_name, last_name, phone, company_id) VALUES('Bherring', 'Paucar', '8754125487', 1);


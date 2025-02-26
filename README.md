
# создание трех ролей

```sql

CREATE ROLE app_connector WITH LOGIN PASSWORD 'connector_password';
GRANT CONNECT ON DATABASE your_database_name TO app_connector;
GRANT USAGE ON SCHEMA public TO app_connector;
GRANT SELECT ON app_users TO app_connector;

CREATE ROLE GlFr_junior WITH LOGIN PASSWORD '137913';
GRANT CONNECT ON DATABASE your_database_name TO GlFr_junior;
GRANT USAGE ON SCHEMA public TO GlFr_junior;
GRANT SELECT ON ALL TABLES IN SCHEMA public TO GlFr_junior;

CREATE ROLE GlFr_admin WITH LOGIN PASSWORD '137913';
GRANT ALL PRIVILEGES ON DATABASE your_database_name TO GlFr_admin;
GRANT ALL PRIVILEGES ON ALL TABLES IN SCHEMA public TO GlFr_admin;
GRANT ALL PRIVILEGES ON ALL SEQUENCES IN SCHEMA public TO GlFr_admin;

```
# создание таблицы для пользователей

```sql
CREATE TABLE app_users (
    user_id SERIAL PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL, 
    role VARCHAR(20) NOT NULL CHECK (role IN ('admin', 'junior')) 
);
```
# примерное заполнение

```sql
INSERT INTO app_users (username, password_hash, role)
VALUES 
    ('admin_user', '137913', 'admin'), -- Замените на реальный хэш
    ('junior_user', '137913', 'junior'); -- Замените на реальный хэш

```


# вспомогательная функция в бд

```sql
CREATE OR REPLACE FUNCTION FIELDID_BY_Name(filedNameInput varchar(100))
RETURNS uuid
LANGUAGE plpgsql
AS $$
DECLARE 
    FIELDID uuid;
BEGIN
    SELECT field_id INTO FIELDID
    FROM fields
    WHERE fields.field_name = filedNameInput;

IF NOT FOUND THEN
        RETURN NULL;
END IF;

RETURN FIELDID;
END;
$$;
```

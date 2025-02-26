
# создание двух ролей

```sql
CREATE ROLE GlFr_junior WITH LOGIN PASSWORD '137913';
GRANT CONNECT ON DATABASE your_database_name TO GlFr_junior;
GRANT USAGE ON SCHEMA public TO GlFr_junior;
GRANT SELECT ON ALL TABLES IN SCHEMA public TO GlFr_junior;

CREATE ROLE GlFr_admin WITH LOGIN PASSWORD '137913';
GRANT ALL PRIVILEGES ON DATABASE your_database_name TO GlFr_admin;
GRANT ALL PRIVILEGES ON ALL TABLES IN SCHEMA public TO GlFr_admin;
GRANT ALL PRIVILEGES ON ALL SEQUENCES IN SCHEMA public TO GlFr_admin;

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

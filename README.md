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

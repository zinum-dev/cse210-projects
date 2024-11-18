class Storage
{
    private Reference _reference;
    private string _scripture;

    public Storage()
    {
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public void SetReference(Reference reference)
    {
        _reference = reference;
    }

    public string GetScripture()
    {
        return _scripture;
    }

    public void SetScripture(string scripture)
    {
        _scripture = scripture;
    }

}
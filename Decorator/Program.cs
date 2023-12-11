namespace Decorator
{
    public interface DataSource
    {
        public void writeData(string data);
        public void readData();
    }

    public class FileDataSource : DataSource
    {
        private string filename;

        public FileDataSource(string filename)
        {
            this.filename = filename;
        }

        public void readData()
        {
            throw new NotImplementedException();
        }

        public void writeData(string data)
        {
            throw new NotImplementedException();
        }
    }


    public abstract class  DataSourceDecorator : DataSource
    {

        private DataSource wrappee;
        public DataSourceDecorator(DataSource wrappee)
        {

            this.wrappee = wrappee;

        }


        public void readData()
        {
            throw new NotImplementedException();
        }

        public void writeData(string data)
        {
            throw new NotImplementedException();
        }
    }



    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(DataSource wrappee) : base(wrappee)
        {
        }

        public void readData()
        {
            throw new NotImplementedException();
        }

        public void writeData(string data)
        {
            throw new NotImplementedException();
        }
    }

    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(DataSource wrappee) : base(wrappee)
        {
        }

        public void readData()
        {
            throw new NotImplementedException();
        }

        public void writeData(string data)
        {
            throw new NotImplementedException();
        }
    }
}
namespace KyHttpClient.Domain {
    public abstract class KyHttpClient {
        
        private string _url;

        public KyHttpClient(string url) {
            _url = url;
        }
    }
}

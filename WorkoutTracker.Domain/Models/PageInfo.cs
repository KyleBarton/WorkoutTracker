namespace WorkoutTracker.Domain.Models
{
    public class PageInfo
    {
        private readonly int _page;
        private readonly int _pageNumber;

        public PageInfo(int page, int pageNumber){
                _page = page;
                _pageNumber = pageNumber;
        }

        public int Page {get {return _page;}}
        public int PageNumber {get {return _pageNumber;}}
        public int RecordsToSkip {
            get {
                return _pageNumber * (_page - 1);
            }
        }
    }
}
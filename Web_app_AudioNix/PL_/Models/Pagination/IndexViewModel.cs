namespace PL.Models.Pagination
{
    public class IndexViewModel
    {
        public IEnumerable<SongView> Songs { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}

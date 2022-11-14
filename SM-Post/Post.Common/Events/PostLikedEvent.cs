using CQRS.Core.Events;

namespace Post.Common.Events;

public class PostLikedEvent : BaseEvent
{
    public PostLikedEvent() : base(nameof(PostLikedEvent))
    {
        
    }

    public string Message { get; set; } = string.Empty;
}
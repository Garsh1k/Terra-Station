using Content.Shared.MassMedia.Systems;
using Robust.Shared.Serialization;

namespace Content.Shared.MassMedia.Components;

[Serializable, NetSerializable]
public enum NewsWriterUiKey : byte
{
    Key
}

[Serializable, NetSerializable]
public sealed class NewsWriterBoundUserInterfaceState : BoundUserInterfaceState
{
    public readonly NewsArticle[] Articles;
    public readonly bool PublishEnabled;
    public readonly TimeSpan NextPublish;
    public readonly string TitleDraft;
    public readonly string ContentDraft;

    public NewsWriterBoundUserInterfaceState(NewsArticle[] articles, bool publishEnabled, TimeSpan nextPublish, string titleDraft, string contentDraft)
    {
        Articles = articles;
        PublishEnabled = publishEnabled;
        NextPublish = nextPublish;
        TitleDraft = titleDraft;
        ContentDraft = contentDraft;
    }
}

[Serializable, NetSerializable]
public sealed class NewsWriterPublishMessage : BoundUserInterfaceMessage
{
    public readonly string Title;
    public readonly string Content;


    public NewsWriterPublishMessage(string title, string content)
    {
        Title = title;
        Content = content;
    }
}

[Serializable, NetSerializable]
public sealed class NewsWriterDeleteMessage : BoundUserInterfaceMessage
{
    public readonly int ArticleNum;

    public NewsWriterDeleteMessage(int num)
    {
        ArticleNum = num;
    }
}

[Serializable, NetSerializable]
public sealed class NewsWriterArticlesRequestMessage : BoundUserInterfaceMessage
{
}

[Serializable, NetSerializable]
public sealed class NewsWriterArticleDraftMessage : BoundUserInterfaceMessage
{
    public readonly string TitleDraft;
    public readonly string ContentDraft;

    public NewsWriterArticleDraftMessage(string titleDraft, string contentDraft)
    {
        TitleDraft = titleDraft;
        ContentDraft = contentDraft;
    }
}

[Serializable, NetSerializable]
public sealed class NewsWriterRequestArticleDraftMessage : BoundUserInterfaceMessage
{
}

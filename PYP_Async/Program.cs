using PYP_Async;

List<string> webSite = new List<string> { "https://buttigieg.medium.com/one-year-in-parenting-has-taught-us-about-vulnerability-and-gratitude-170f6e94cbad", "https://medium.com/@anastasiabasilcunningham/crotch-is-not-a-dress-length-797346183e32?source=read_next_recirc---------0---------------------62cb1871_ddf4_413f_9d1f_478bbb5b2045-------", "https://medium.com/@traviswking-ntaa/four-uniquely-mexican-things-that-the-whole-world-should-adopt-12b4799621b", "https://medium.com/the-no%C3%B6sphere?source=read_next_recirc---------0---------------------facf2427_0cee_4865_bc4b_9a433b6813a3-------" };

WebSiteTracker webSiteTracker = new WebSiteTracker();
await webSiteTracker.Tracker(webSite);

await webSiteTracker.TaskAsync(webSite);
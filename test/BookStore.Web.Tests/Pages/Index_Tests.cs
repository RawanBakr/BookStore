﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace BookStore.Pages;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class Index_Tests : BookStoreWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

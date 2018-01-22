﻿namespace Ironclad.Tests.Sdk
{
    using Xunit;

    // LINK (Cameron): https://xunit.github.io/docs/shared-context.html
    [CollectionDefinition("Ironclad")]
    public class IroncladCollection : ICollectionFixture<IroncladFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}

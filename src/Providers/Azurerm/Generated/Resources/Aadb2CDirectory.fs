namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.Aadb2CDirectory.Aadb2CDirectoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/aadb2c_directory">azurerm_aadb2c_directory</a>.
    /// </summary>
    type Aadb2CDirectoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : Aadb2CDirectoryState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Aadb2CDirectoryState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Aadb2CDirectoryState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Aadb2CDirectoryState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Location in which the B2C tenant is hosted and data resides. See https://aka.ms/B2CDataResidency for more information. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/aadb2c_directory#data_residency_location-1">Aadb2CDirectory#data_residency_location</a>
        /// </summary>
        [<CustomOperation "data_residency_location">]
        member _.DataResidencyLocation(state: Aadb2CDirectoryState<Missing, 'DomainName, 'ResourceGroupName, 'SkuName>, value: string) : Aadb2CDirectoryState<Present, 'DomainName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.DataResidencyLocation <- value)
            ({ assignments = state.assignments } : Aadb2CDirectoryState<Present, 'DomainName, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Domain name of the B2C tenant, including onmicrosoft.com suffix. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/aadb2c_directory#domain_name-1">Aadb2CDirectory#domain_name</a>
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: Aadb2CDirectoryState<'DataResidencyLocation, Missing, 'ResourceGroupName, 'SkuName>, value: string) : Aadb2CDirectoryState<'DataResidencyLocation, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : Aadb2CDirectoryState<'DataResidencyLocation, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/aadb2c_directory#resource_group_name-1">Aadb2CDirectory#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, Missing, 'SkuName>, value: string) : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, Present, 'SkuName>)

        /// <summary>
        /// Billing SKU for the B2C tenant. See https://aka.ms/b2cBilling for more information. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/aadb2c_directory#sku_name-1">Aadb2CDirectory#sku_name</a>
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, Missing>, value: string) : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Country code of the B2C tenant. See https://aka.ms/B2CDataResidency for valid country codes. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/aadb2c_directory#country_code-1">Aadb2CDirectory#country_code</a>
        /// </summary>
        [<CustomOperation "country_code">]
        member _.CountryCode(state: Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName>, value: string) : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.CountryCode <- value)
            state : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// The initial display name of the B2C tenant. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/aadb2c_directory#display_name-1">Aadb2CDirectory#display_name</a>
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName>, value: string) : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/aadb2c_directory#id-1">Aadb2CDirectory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName>, value: string) : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/aadb2c_directory#tags-1">Aadb2CDirectory#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/aadb2c_directory#timeouts-1">Aadb2CDirectory#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName>, value: azurerm.Aadb2CDirectory.Aadb2CDirectoryTimeouts) : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Aadb2CDirectoryState<'DataResidencyLocation, 'DomainName, 'ResourceGroupName, 'SkuName>

        member _.Run(state: Aadb2CDirectoryState<Present, Present, Present, Present>) : azurerm.Aadb2CDirectory.Aadb2CDirectory =
            let config = azurerm.Aadb2CDirectory.Aadb2CDirectoryConfig()
            for setter in state.assignments do
                setter config
            azurerm.Aadb2CDirectory.Aadb2CDirectory(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.aadb2CDirectory: missing required arguments. Must call: data_residency_location, domain_name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: Aadb2CDirectoryState<_, _, _, _>) : azurerm.Aadb2CDirectory.Aadb2CDirectory =
            Unchecked.defaultof<azurerm.Aadb2CDirectory.Aadb2CDirectory>

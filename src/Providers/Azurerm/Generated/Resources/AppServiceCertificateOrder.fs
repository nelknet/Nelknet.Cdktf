namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AppServiceCertificateOrder.AppServiceCertificateOrderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order">azurerm_app_service_certificate_order</a>.
    /// </summary>
    type AppServiceCertificateOrderBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceCertificateOrderState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceCertificateOrderState<Missing, Missing, Missing>)

        member _.Zero(()) : AppServiceCertificateOrderState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceCertificateOrderState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order#location-1">AppServiceCertificateOrder#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AppServiceCertificateOrderState<Missing, 'Name, 'ResourceGroupName>, value: string) : AppServiceCertificateOrderState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AppServiceCertificateOrderState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order#name-1">AppServiceCertificateOrder#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppServiceCertificateOrderState<'Location, Missing, 'ResourceGroupName>, value: string) : AppServiceCertificateOrderState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppServiceCertificateOrderState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order#resource_group_name-1">AppServiceCertificateOrder#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AppServiceCertificateOrderState<'Location, 'Name, Missing>, value: string) : AppServiceCertificateOrderState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AppServiceCertificateOrderState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order#auto_renew-1">AppServiceCertificateOrder#auto_renew</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_renew">]
        member _.AutoRenew(state: AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>, value: bool) : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoRenew <- value)
            state : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order#auto_renew-1">AppServiceCertificateOrder#auto_renew</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_renew">]
        member _.AutoRenew(state: AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoRenew <- value)
            state : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order#csr-1">AppServiceCertificateOrder#csr</a>.
        /// </summary>
        [<CustomOperation "csr">]
        member _.Csr(state: AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Csr <- value)
            state : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order#distinguished_name-1">AppServiceCertificateOrder#distinguished_name</a>.
        /// </summary>
        [<CustomOperation "distinguished_name">]
        member _.DistinguishedName(state: AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DistinguishedName <- value)
            state : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order#id-1">AppServiceCertificateOrder#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order#key_size-1">AppServiceCertificateOrder#key_size</a>.
        /// </summary>
        [<CustomOperation "key_size">]
        member _.KeySize(state: AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>, value: double) : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeySize <- value)
            state : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order#product_type-1">AppServiceCertificateOrder#product_type</a>.
        /// </summary>
        [<CustomOperation "product_type">]
        member _.ProductType(state: AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProductType <- value)
            state : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order#tags-1">AppServiceCertificateOrder#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order#timeouts-1">AppServiceCertificateOrder#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppServiceCertificateOrder.AppServiceCertificateOrderTimeouts) : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_order#validity_in_years-1">AppServiceCertificateOrder#validity_in_years</a>.
        /// </summary>
        [<CustomOperation "validity_in_years">]
        member _.ValidityInYears(state: AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>, value: double) : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ValidityInYears <- value)
            state : AppServiceCertificateOrderState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: AppServiceCertificateOrderState<Present, Present, Present>) : azurerm.AppServiceCertificateOrder.AppServiceCertificateOrder =
            let config = azurerm.AppServiceCertificateOrder.AppServiceCertificateOrderConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceCertificateOrder.AppServiceCertificateOrder(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceCertificateOrder: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AppServiceCertificateOrderState<_, _, _>) : azurerm.AppServiceCertificateOrder.AppServiceCertificateOrder =
            Unchecked.defaultof<azurerm.AppServiceCertificateOrder.AppServiceCertificateOrder>

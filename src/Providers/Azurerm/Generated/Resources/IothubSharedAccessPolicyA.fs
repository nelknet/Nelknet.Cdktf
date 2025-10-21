namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IothubSharedAccessPolicy.IothubSharedAccessPolicyAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy">azurerm_iothub_shared_access_policy</a>.
    /// </summary>
    type IothubSharedAccessPolicyABuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubSharedAccessPolicyAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubSharedAccessPolicyAState<Missing, Missing, Missing>)

        member _.Zero(()) : IothubSharedAccessPolicyAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubSharedAccessPolicyAState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy#iothub_name-1">IothubSharedAccessPolicyA#iothub_name</a>.
        /// </summary>
        [<CustomOperation "iothub_name">]
        member _.IothubName(state: IothubSharedAccessPolicyAState<Missing, 'Name, 'ResourceGroupName>, value: string) : IothubSharedAccessPolicyAState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IothubName <- value)
            ({ assignments = state.assignments } : IothubSharedAccessPolicyAState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy#name-1">IothubSharedAccessPolicyA#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubSharedAccessPolicyAState<'IothubName, Missing, 'ResourceGroupName>, value: string) : IothubSharedAccessPolicyAState<'IothubName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubSharedAccessPolicyAState<'IothubName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy#resource_group_name-1">IothubSharedAccessPolicyA#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubSharedAccessPolicyAState<'IothubName, 'Name, Missing>, value: string) : IothubSharedAccessPolicyAState<'IothubName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubSharedAccessPolicyAState<'IothubName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy#device_connect-1">IothubSharedAccessPolicyA#device_connect</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "device_connect">]
        member _.DeviceConnect(state: IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>, value: bool) : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DeviceConnect <- value)
            state : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy#device_connect-1">IothubSharedAccessPolicyA#device_connect</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "device_connect">]
        member _.DeviceConnect(state: IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DeviceConnect <- value)
            state : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy#id-1">IothubSharedAccessPolicyA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>, value: string) : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy#registry_read-1">IothubSharedAccessPolicyA#registry_read</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "registry_read">]
        member _.RegistryRead(state: IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>, value: bool) : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RegistryRead <- value)
            state : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy#registry_read-1">IothubSharedAccessPolicyA#registry_read</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "registry_read">]
        member _.RegistryRead(state: IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RegistryRead <- value)
            state : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy#registry_write-1">IothubSharedAccessPolicyA#registry_write</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "registry_write">]
        member _.RegistryWrite(state: IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>, value: bool) : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RegistryWrite <- value)
            state : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy#registry_write-1">IothubSharedAccessPolicyA#registry_write</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "registry_write">]
        member _.RegistryWrite(state: IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RegistryWrite <- value)
            state : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy#service_connect-1">IothubSharedAccessPolicyA#service_connect</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "service_connect">]
        member _.ServiceConnect(state: IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>, value: bool) : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ServiceConnect <- value)
            state : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy#service_connect-1">IothubSharedAccessPolicyA#service_connect</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "service_connect">]
        member _.ServiceConnect(state: IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ServiceConnect <- value)
            state : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_shared_access_policy#timeouts-1">IothubSharedAccessPolicyA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>, value: azurerm.IothubSharedAccessPolicy.IothubSharedAccessPolicyTimeouts) : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubSharedAccessPolicyAState<'IothubName, 'Name, 'ResourceGroupName>

        member _.Run(state: IothubSharedAccessPolicyAState<Present, Present, Present>) : azurerm.IothubSharedAccessPolicy.IothubSharedAccessPolicyA =
            let config = azurerm.IothubSharedAccessPolicy.IothubSharedAccessPolicyAConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubSharedAccessPolicy.IothubSharedAccessPolicyA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubSharedAccessPolicyA: missing required arguments. Must call: iothub_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IothubSharedAccessPolicyAState<_, _, _>) : azurerm.IothubSharedAccessPolicy.IothubSharedAccessPolicyA =
            Unchecked.defaultof<azurerm.IothubSharedAccessPolicy.IothubSharedAccessPolicyA>

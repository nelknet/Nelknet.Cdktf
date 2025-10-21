namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IothubDpsSharedAccessPolicy.IothubDpsSharedAccessPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy">azurerm_iothub_dps_shared_access_policy</a>.
    /// </summary>
    type IothubDpsSharedAccessPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubDpsSharedAccessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubDpsSharedAccessPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : IothubDpsSharedAccessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubDpsSharedAccessPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#iothub_dps_name-1">IothubDpsSharedAccessPolicy#iothub_dps_name</a>.
        /// </summary>
        [<CustomOperation "iothub_dps_name">]
        member _.IothubDpsName(state: IothubDpsSharedAccessPolicyState<Missing, 'Name, 'ResourceGroupName>, value: string) : IothubDpsSharedAccessPolicyState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IothubDpsName <- value)
            ({ assignments = state.assignments } : IothubDpsSharedAccessPolicyState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#name-1">IothubDpsSharedAccessPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, Missing, 'ResourceGroupName>, value: string) : IothubDpsSharedAccessPolicyState<'IothubDpsName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubDpsSharedAccessPolicyState<'IothubDpsName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#resource_group_name-1">IothubDpsSharedAccessPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, Missing>, value: string) : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#enrollment_read-1">IothubDpsSharedAccessPolicy#enrollment_read</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enrollment_read">]
        member _.EnrollmentRead(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: bool) : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EnrollmentRead <- value)
            state : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#enrollment_read-1">IothubDpsSharedAccessPolicy#enrollment_read</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enrollment_read">]
        member _.EnrollmentRead(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EnrollmentRead <- value)
            state : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#enrollment_write-1">IothubDpsSharedAccessPolicy#enrollment_write</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enrollment_write">]
        member _.EnrollmentWrite(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: bool) : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EnrollmentWrite <- value)
            state : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#enrollment_write-1">IothubDpsSharedAccessPolicy#enrollment_write</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enrollment_write">]
        member _.EnrollmentWrite(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EnrollmentWrite <- value)
            state : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#id-1">IothubDpsSharedAccessPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: string) : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#registration_read-1">IothubDpsSharedAccessPolicy#registration_read</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "registration_read">]
        member _.RegistrationRead(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: bool) : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RegistrationRead <- value)
            state : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#registration_read-1">IothubDpsSharedAccessPolicy#registration_read</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "registration_read">]
        member _.RegistrationRead(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RegistrationRead <- value)
            state : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#registration_write-1">IothubDpsSharedAccessPolicy#registration_write</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "registration_write">]
        member _.RegistrationWrite(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: bool) : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RegistrationWrite <- value)
            state : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#registration_write-1">IothubDpsSharedAccessPolicy#registration_write</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "registration_write">]
        member _.RegistrationWrite(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RegistrationWrite <- value)
            state : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#service_config-1">IothubDpsSharedAccessPolicy#service_config</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "service_config">]
        member _.ServiceConfig(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: bool) : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ServiceConfig <- value)
            state : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#service_config-1">IothubDpsSharedAccessPolicy#service_config</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "service_config">]
        member _.ServiceConfig(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ServiceConfig <- value)
            state : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_shared_access_policy#timeouts-1">IothubDpsSharedAccessPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: azurerm.IothubDpsSharedAccessPolicy.IothubDpsSharedAccessPolicyTimeouts) : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        member _.Run(state: IothubDpsSharedAccessPolicyState<Present, Present, Present>) : azurerm.IothubDpsSharedAccessPolicy.IothubDpsSharedAccessPolicy =
            let config = azurerm.IothubDpsSharedAccessPolicy.IothubDpsSharedAccessPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubDpsSharedAccessPolicy.IothubDpsSharedAccessPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubDpsSharedAccessPolicy: missing required arguments. Must call: iothub_dps_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IothubDpsSharedAccessPolicyState<_, _, _>) : azurerm.IothubDpsSharedAccessPolicy.IothubDpsSharedAccessPolicy =
            Unchecked.defaultof<azurerm.IothubDpsSharedAccessPolicy.IothubDpsSharedAccessPolicy>

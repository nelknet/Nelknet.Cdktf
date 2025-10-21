namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId> = { assignments: ResizeArray<azurerm.IothubFileUpload.IothubFileUploadAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload">azurerm_iothub_file_upload</a>.
    /// </summary>
    type IothubFileUploadABuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubFileUploadAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubFileUploadAState<Missing, Missing, Missing>)

        member _.Zero(()) : IothubFileUploadAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubFileUploadAState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload#connection_string-1">IothubFileUploadA#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: IothubFileUploadAState<Missing, 'ContainerName, 'IothubId>, value: string) : IothubFileUploadAState<Present, 'ContainerName, 'IothubId> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            ({ assignments = state.assignments } : IothubFileUploadAState<Present, 'ContainerName, 'IothubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload#container_name-1">IothubFileUploadA#container_name</a>.
        /// </summary>
        [<CustomOperation "container_name">]
        member _.ContainerName(state: IothubFileUploadAState<'ConnectionString, Missing, 'IothubId>, value: string) : IothubFileUploadAState<'ConnectionString, Present, 'IothubId> =
            state.assignments.Add(fun config -> config.ContainerName <- value)
            ({ assignments = state.assignments } : IothubFileUploadAState<'ConnectionString, Present, 'IothubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload#iothub_id-1">IothubFileUploadA#iothub_id</a>.
        /// </summary>
        [<CustomOperation "iothub_id">]
        member _.IothubId(state: IothubFileUploadAState<'ConnectionString, 'ContainerName, Missing>, value: string) : IothubFileUploadAState<'ConnectionString, 'ContainerName, Present> =
            state.assignments.Add(fun config -> config.IothubId <- value)
            ({ assignments = state.assignments } : IothubFileUploadAState<'ConnectionString, 'ContainerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload#authentication_type-1">IothubFileUploadA#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>, value: string) : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            state : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload#default_ttl-1">IothubFileUploadA#default_ttl</a>.
        /// </summary>
        [<CustomOperation "default_ttl">]
        member _.DefaultTtl(state: IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>, value: string) : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId> =
            state.assignments.Add(fun config -> config.DefaultTtl <- value)
            state : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload#id-1">IothubFileUploadA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>, value: string) : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload#identity_id-1">IothubFileUploadA#identity_id</a>.
        /// </summary>
        [<CustomOperation "identity_id">]
        member _.IdentityId(state: IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>, value: string) : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId> =
            state.assignments.Add(fun config -> config.IdentityId <- value)
            state : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload#lock_duration-1">IothubFileUploadA#lock_duration</a>.
        /// </summary>
        [<CustomOperation "lock_duration">]
        member _.LockDuration(state: IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>, value: string) : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId> =
            state.assignments.Add(fun config -> config.LockDuration <- value)
            state : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload#max_delivery_count-1">IothubFileUploadA#max_delivery_count</a>.
        /// </summary>
        [<CustomOperation "max_delivery_count">]
        member _.MaxDeliveryCount(state: IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>, value: double) : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId> =
            state.assignments.Add(fun config -> config.MaxDeliveryCount <- value)
            state : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload#notifications_enabled-1">IothubFileUploadA#notifications_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "notifications_enabled">]
        member _.NotificationsEnabled(state: IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>, value: bool) : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId> =
            state.assignments.Add(fun config -> config.NotificationsEnabled <- value)
            state : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload#notifications_enabled-1">IothubFileUploadA#notifications_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "notifications_enabled">]
        member _.NotificationsEnabled(state: IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>, value: HashiCorp.Cdktf.IResolvable) : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId> =
            state.assignments.Add(fun config -> config.NotificationsEnabled <- value)
            state : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload#sas_ttl-1">IothubFileUploadA#sas_ttl</a>.
        /// </summary>
        [<CustomOperation "sas_ttl">]
        member _.SasTtl(state: IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>, value: string) : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId> =
            state.assignments.Add(fun config -> config.SasTtl <- value)
            state : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_file_upload#timeouts-1">IothubFileUploadA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>, value: azurerm.IothubFileUpload.IothubFileUploadTimeouts) : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubFileUploadAState<'ConnectionString, 'ContainerName, 'IothubId>

        member _.Run(state: IothubFileUploadAState<Present, Present, Present>) : azurerm.IothubFileUpload.IothubFileUploadA =
            let config = azurerm.IothubFileUpload.IothubFileUploadAConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubFileUpload.IothubFileUploadA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubFileUploadA: missing required arguments. Must call: connection_string, container_name, iothub_id.", 9999, IsError = true)>]
        member _.Run(_: IothubFileUploadAState<_, _, _>) : azurerm.IothubFileUpload.IothubFileUploadA =
            Unchecked.defaultof<azurerm.IothubFileUpload.IothubFileUploadA>

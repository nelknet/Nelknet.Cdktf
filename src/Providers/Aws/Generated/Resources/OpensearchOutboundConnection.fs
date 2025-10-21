namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo> = { assignments: ResizeArray<aws.OpensearchOutboundConnection.OpensearchOutboundConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection">aws_opensearch_outbound_connection</a>.
    /// </summary>
    type OpensearchOutboundConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchOutboundConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchOutboundConnectionState<Missing, Missing, Missing>)

        member _.Zero(()) : OpensearchOutboundConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchOutboundConnectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#connection_alias-1">OpensearchOutboundConnection#connection_alias</a>.
        /// </summary>
        [<CustomOperation "connection_alias">]
        member _.ConnectionAlias(state: OpensearchOutboundConnectionState<Missing, 'LocalDomainInfo, 'RemoteDomainInfo>, value: string) : OpensearchOutboundConnectionState<Present, 'LocalDomainInfo, 'RemoteDomainInfo> =
            state.assignments.Add(fun config -> config.ConnectionAlias <- value)
            ({ assignments = state.assignments } : OpensearchOutboundConnectionState<Present, 'LocalDomainInfo, 'RemoteDomainInfo>)

        /// <summary>
        /// local_domain_info block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#local_domain_info-1">OpensearchOutboundConnection#local_domain_info</a>
        /// </summary>
        [<CustomOperation "local_domain_info">]
        member _.LocalDomainInfo(state: OpensearchOutboundConnectionState<'ConnectionAlias, Missing, 'RemoteDomainInfo>, value: aws.OpensearchOutboundConnection.OpensearchOutboundConnectionLocalDomainInfo) : OpensearchOutboundConnectionState<'ConnectionAlias, Present, 'RemoteDomainInfo> =
            state.assignments.Add(fun config -> config.LocalDomainInfo <- value)
            ({ assignments = state.assignments } : OpensearchOutboundConnectionState<'ConnectionAlias, Present, 'RemoteDomainInfo>)

        /// <summary>
        /// remote_domain_info block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#remote_domain_info-1">OpensearchOutboundConnection#remote_domain_info</a>
        /// </summary>
        [<CustomOperation "remote_domain_info">]
        member _.RemoteDomainInfo(state: OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, Missing>, value: aws.OpensearchOutboundConnection.OpensearchOutboundConnectionRemoteDomainInfo) : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, Present> =
            state.assignments.Add(fun config -> config.RemoteDomainInfo <- value)
            ({ assignments = state.assignments } : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#accept_connection-1">OpensearchOutboundConnection#accept_connection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "accept_connection">]
        member _.AcceptConnection(state: OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo>, value: bool) : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo> =
            state.assignments.Add(fun config -> config.AcceptConnection <- value)
            state : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#accept_connection-1">OpensearchOutboundConnection#accept_connection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "accept_connection">]
        member _.AcceptConnection(state: OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo>, value: HashiCorp.Cdktf.IResolvable) : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo> =
            state.assignments.Add(fun config -> config.AcceptConnection <- value)
            state : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#connection_mode-1">OpensearchOutboundConnection#connection_mode</a>.
        /// </summary>
        [<CustomOperation "connection_mode">]
        member _.ConnectionMode(state: OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo>, value: string) : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo> =
            state.assignments.Add(fun config -> config.ConnectionMode <- value)
            state : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo>

        /// <summary>
        /// connection_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#connection_properties-1">OpensearchOutboundConnection#connection_properties</a>
        /// </summary>
        [<CustomOperation "connection_properties">]
        member _.ConnectionProperties(state: OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo>, value: aws.OpensearchOutboundConnection.OpensearchOutboundConnectionConnectionProperties) : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo> =
            state.assignments.Add(fun config -> config.ConnectionProperties <- value)
            state : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#id-1">OpensearchOutboundConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo>, value: string) : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#timeouts-1">OpensearchOutboundConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo>, value: aws.OpensearchOutboundConnection.OpensearchOutboundConnectionTimeouts) : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OpensearchOutboundConnectionState<'ConnectionAlias, 'LocalDomainInfo, 'RemoteDomainInfo>

        member _.Run(state: OpensearchOutboundConnectionState<Present, Present, Present>) : aws.OpensearchOutboundConnection.OpensearchOutboundConnection =
            let config = aws.OpensearchOutboundConnection.OpensearchOutboundConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchOutboundConnection.OpensearchOutboundConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchOutboundConnection: missing required arguments. Must call: connection_alias, local_domain_info, remote_domain_info.", 9999, IsError = true)>]
        member _.Run(_: OpensearchOutboundConnectionState<_, _, _>) : aws.OpensearchOutboundConnection.OpensearchOutboundConnection =
            Unchecked.defaultof<aws.OpensearchOutboundConnection.OpensearchOutboundConnection>

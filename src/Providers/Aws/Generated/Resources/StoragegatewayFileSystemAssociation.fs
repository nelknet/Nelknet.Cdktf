namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username> = { assignments: ResizeArray<aws.StoragegatewayFileSystemAssociation.StoragegatewayFileSystemAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association">aws_storagegateway_file_system_association</a>.
    /// </summary>
    type StoragegatewayFileSystemAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : StoragegatewayFileSystemAssociationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayFileSystemAssociationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StoragegatewayFileSystemAssociationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayFileSystemAssociationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association#gateway_arn-1">StoragegatewayFileSystemAssociation#gateway_arn</a>.
        /// </summary>
        [<CustomOperation "gateway_arn">]
        member _.GatewayArn(state: StoragegatewayFileSystemAssociationState<Missing, 'LocationArn, 'Password, 'Username>, value: string) : StoragegatewayFileSystemAssociationState<Present, 'LocationArn, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.GatewayArn <- value)
            ({ assignments = state.assignments } : StoragegatewayFileSystemAssociationState<Present, 'LocationArn, 'Password, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association#location_arn-1">StoragegatewayFileSystemAssociation#location_arn</a>.
        /// </summary>
        [<CustomOperation "location_arn">]
        member _.LocationArn(state: StoragegatewayFileSystemAssociationState<'GatewayArn, Missing, 'Password, 'Username>, value: string) : StoragegatewayFileSystemAssociationState<'GatewayArn, Present, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.LocationArn <- value)
            ({ assignments = state.assignments } : StoragegatewayFileSystemAssociationState<'GatewayArn, Present, 'Password, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association#password-1">StoragegatewayFileSystemAssociation#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, Missing, 'Username>, value: string) : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, Present, 'Username> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, Present, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association#username-1">StoragegatewayFileSystemAssociation#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, Missing>, value: string) : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, Present> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association#audit_destination_arn-1">StoragegatewayFileSystemAssociation#audit_destination_arn</a>.
        /// </summary>
        [<CustomOperation "audit_destination_arn">]
        member _.AuditDestinationArn(state: StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username>, value: string) : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.AuditDestinationArn <- value)
            state : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username>

        /// <summary>
        /// cache_attributes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association#cache_attributes-1">StoragegatewayFileSystemAssociation#cache_attributes</a>
        /// </summary>
        [<CustomOperation "cache_attributes">]
        member _.CacheAttributes(state: StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username>, value: aws.StoragegatewayFileSystemAssociation.StoragegatewayFileSystemAssociationCacheAttributes) : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.CacheAttributes <- value)
            state : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association#id-1">StoragegatewayFileSystemAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username>, value: string) : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association#tags-1">StoragegatewayFileSystemAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username>, value: seq<string * string>) : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association#tags_all-1">StoragegatewayFileSystemAssociation#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username>, value: seq<string * string>) : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association#timeouts-1">StoragegatewayFileSystemAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username>, value: aws.StoragegatewayFileSystemAssociation.StoragegatewayFileSystemAssociationTimeouts) : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StoragegatewayFileSystemAssociationState<'GatewayArn, 'LocationArn, 'Password, 'Username>

        member _.Run(state: StoragegatewayFileSystemAssociationState<Present, Present, Present, Present>) : aws.StoragegatewayFileSystemAssociation.StoragegatewayFileSystemAssociation =
            let config = aws.StoragegatewayFileSystemAssociation.StoragegatewayFileSystemAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.StoragegatewayFileSystemAssociation.StoragegatewayFileSystemAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.storagegatewayFileSystemAssociation: missing required arguments. Must call: gateway_arn, location_arn, password, username.", 9999, IsError = true)>]
        member _.Run(_: StoragegatewayFileSystemAssociationState<_, _, _, _>) : aws.StoragegatewayFileSystemAssociation.StoragegatewayFileSystemAssociation =
            Unchecked.defaultof<aws.StoragegatewayFileSystemAssociation.StoragegatewayFileSystemAssociation>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> = { assignments: ResizeArray<aws.StoragegatewayNfsFileShare.StoragegatewayNfsFileShareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share">aws_storagegateway_nfs_file_share</a>.
    /// </summary>
    type StoragegatewayNfsFileShareBuilder(logicalId: string) =
        member _.Yield(_: unit) : StoragegatewayNfsFileShareState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayNfsFileShareState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StoragegatewayNfsFileShareState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayNfsFileShareState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#client_list-1">StoragegatewayNfsFileShare#client_list</a>.
        /// </summary>
        [<CustomOperation "client_list">]
        member _.ClientList(state: StoragegatewayNfsFileShareState<Missing, 'GatewayArn, 'LocationArn, 'RoleArn>, value: seq<string>) : StoragegatewayNfsFileShareState<Present, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.ClientList <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : StoragegatewayNfsFileShareState<Present, 'GatewayArn, 'LocationArn, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#gateway_arn-1">StoragegatewayNfsFileShare#gateway_arn</a>.
        /// </summary>
        [<CustomOperation "gateway_arn">]
        member _.GatewayArn(state: StoragegatewayNfsFileShareState<'ClientList, Missing, 'LocationArn, 'RoleArn>, value: string) : StoragegatewayNfsFileShareState<'ClientList, Present, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.GatewayArn <- value)
            ({ assignments = state.assignments } : StoragegatewayNfsFileShareState<'ClientList, Present, 'LocationArn, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#location_arn-1">StoragegatewayNfsFileShare#location_arn</a>.
        /// </summary>
        [<CustomOperation "location_arn">]
        member _.LocationArn(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, Missing, 'RoleArn>, value: string) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.LocationArn <- value)
            ({ assignments = state.assignments } : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#role_arn-1">StoragegatewayNfsFileShare#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, Missing>, value: string) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#audit_destination_arn-1">StoragegatewayNfsFileShare#audit_destination_arn</a>.
        /// </summary>
        [<CustomOperation "audit_destination_arn">]
        member _.AuditDestinationArn(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.AuditDestinationArn <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#bucket_region-1">StoragegatewayNfsFileShare#bucket_region</a>.
        /// </summary>
        [<CustomOperation "bucket_region">]
        member _.BucketRegion(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.BucketRegion <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// cache_attributes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#cache_attributes-1">StoragegatewayNfsFileShare#cache_attributes</a>
        /// </summary>
        [<CustomOperation "cache_attributes">]
        member _.CacheAttributes(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: aws.StoragegatewayNfsFileShare.StoragegatewayNfsFileShareCacheAttributes) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.CacheAttributes <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#default_storage_class-1">StoragegatewayNfsFileShare#default_storage_class</a>.
        /// </summary>
        [<CustomOperation "default_storage_class">]
        member _.DefaultStorageClass(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.DefaultStorageClass <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#file_share_name-1">StoragegatewayNfsFileShare#file_share_name</a>.
        /// </summary>
        [<CustomOperation "file_share_name">]
        member _.FileShareName(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.FileShareName <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#guess_mime_type_enabled-1">StoragegatewayNfsFileShare#guess_mime_type_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "guess_mime_type_enabled">]
        member _.GuessMimeTypeEnabled(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: bool) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.GuessMimeTypeEnabled <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#guess_mime_type_enabled-1">StoragegatewayNfsFileShare#guess_mime_type_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "guess_mime_type_enabled">]
        member _.GuessMimeTypeEnabled(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.GuessMimeTypeEnabled <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#id-1">StoragegatewayNfsFileShare#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#kms_encrypted-1">StoragegatewayNfsFileShare#kms_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "kms_encrypted">]
        member _.KmsEncrypted(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: bool) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.KmsEncrypted <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#kms_encrypted-1">StoragegatewayNfsFileShare#kms_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "kms_encrypted">]
        member _.KmsEncrypted(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.KmsEncrypted <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#kms_key_arn-1">StoragegatewayNfsFileShare#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// nfs_file_share_defaults block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#nfs_file_share_defaults-1">StoragegatewayNfsFileShare#nfs_file_share_defaults</a>
        /// </summary>
        [<CustomOperation "nfs_file_share_defaults">]
        member _.NfsFileShareDefaults(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: aws.StoragegatewayNfsFileShare.StoragegatewayNfsFileShareNfsFileShareDefaults) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.NfsFileShareDefaults <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#notification_policy-1">StoragegatewayNfsFileShare#notification_policy</a>.
        /// </summary>
        [<CustomOperation "notification_policy">]
        member _.NotificationPolicy(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.NotificationPolicy <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#object_acl-1">StoragegatewayNfsFileShare#object_acl</a>.
        /// </summary>
        [<CustomOperation "object_acl">]
        member _.ObjectAcl(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.ObjectAcl <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#read_only-1">StoragegatewayNfsFileShare#read_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "read_only">]
        member _.ReadOnly(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: bool) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.ReadOnly <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#read_only-1">StoragegatewayNfsFileShare#read_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "read_only">]
        member _.ReadOnly(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.ReadOnly <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#requester_pays-1">StoragegatewayNfsFileShare#requester_pays</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "requester_pays">]
        member _.RequesterPays(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: bool) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.RequesterPays <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#requester_pays-1">StoragegatewayNfsFileShare#requester_pays</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "requester_pays">]
        member _.RequesterPays(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.RequesterPays <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#squash-1">StoragegatewayNfsFileShare#squash</a>.
        /// </summary>
        [<CustomOperation "squash">]
        member _.Squash(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.Squash <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#tags-1">StoragegatewayNfsFileShare#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: seq<string * string>) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#tags_all-1">StoragegatewayNfsFileShare#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: seq<string * string>) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#timeouts-1">StoragegatewayNfsFileShare#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: aws.StoragegatewayNfsFileShare.StoragegatewayNfsFileShareTimeouts) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_nfs_file_share#vpc_endpoint_dns_name-1">StoragegatewayNfsFileShare#vpc_endpoint_dns_name</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_dns_name">]
        member _.VpcEndpointDnsName(state: StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.VpcEndpointDnsName <- value)
            state : StoragegatewayNfsFileShareState<'ClientList, 'GatewayArn, 'LocationArn, 'RoleArn>

        member _.Run(state: StoragegatewayNfsFileShareState<Present, Present, Present, Present>) : aws.StoragegatewayNfsFileShare.StoragegatewayNfsFileShare =
            let config = aws.StoragegatewayNfsFileShare.StoragegatewayNfsFileShareConfig()
            for setter in state.assignments do
                setter config
            aws.StoragegatewayNfsFileShare.StoragegatewayNfsFileShare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.storagegatewayNfsFileShare: missing required arguments. Must call: client_list, gateway_arn, location_arn, role_arn.", 9999, IsError = true)>]
        member _.Run(_: StoragegatewayNfsFileShareState<_, _, _, _>) : aws.StoragegatewayNfsFileShare.StoragegatewayNfsFileShare =
            Unchecked.defaultof<aws.StoragegatewayNfsFileShare.StoragegatewayNfsFileShare>

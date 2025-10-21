namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> = { assignments: ResizeArray<aws.StoragegatewaySmbFileShare.StoragegatewaySmbFileShareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share">aws_storagegateway_smb_file_share</a>.
    /// </summary>
    type StoragegatewaySmbFileShareBuilder(logicalId: string) =
        member _.Yield(_: unit) : StoragegatewaySmbFileShareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewaySmbFileShareState<Missing, Missing, Missing>)

        member _.Zero(()) : StoragegatewaySmbFileShareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewaySmbFileShareState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#gateway_arn-1">StoragegatewaySmbFileShare#gateway_arn</a>.
        /// </summary>
        [<CustomOperation "gateway_arn">]
        member _.GatewayArn(state: StoragegatewaySmbFileShareState<Missing, 'LocationArn, 'RoleArn>, value: string) : StoragegatewaySmbFileShareState<Present, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.GatewayArn <- value)
            ({ assignments = state.assignments } : StoragegatewaySmbFileShareState<Present, 'LocationArn, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#location_arn-1">StoragegatewaySmbFileShare#location_arn</a>.
        /// </summary>
        [<CustomOperation "location_arn">]
        member _.LocationArn(state: StoragegatewaySmbFileShareState<'GatewayArn, Missing, 'RoleArn>, value: string) : StoragegatewaySmbFileShareState<'GatewayArn, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.LocationArn <- value)
            ({ assignments = state.assignments } : StoragegatewaySmbFileShareState<'GatewayArn, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#role_arn-1">StoragegatewaySmbFileShare#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, Missing>, value: string) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#access_based_enumeration-1">StoragegatewaySmbFileShare#access_based_enumeration</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "access_based_enumeration">]
        member _.AccessBasedEnumeration(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: bool) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.AccessBasedEnumeration <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#access_based_enumeration-1">StoragegatewaySmbFileShare#access_based_enumeration</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "access_based_enumeration">]
        member _.AccessBasedEnumeration(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.AccessBasedEnumeration <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#admin_user_list-1">StoragegatewaySmbFileShare#admin_user_list</a>.
        /// </summary>
        [<CustomOperation "admin_user_list">]
        member _.AdminUserList(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: seq<string>) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.AdminUserList <- (value |> Seq.toArray))
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#audit_destination_arn-1">StoragegatewaySmbFileShare#audit_destination_arn</a>.
        /// </summary>
        [<CustomOperation "audit_destination_arn">]
        member _.AuditDestinationArn(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.AuditDestinationArn <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#authentication-1">StoragegatewaySmbFileShare#authentication</a>.
        /// </summary>
        [<CustomOperation "authentication">]
        member _.Authentication(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.Authentication <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#bucket_region-1">StoragegatewaySmbFileShare#bucket_region</a>.
        /// </summary>
        [<CustomOperation "bucket_region">]
        member _.BucketRegion(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.BucketRegion <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// cache_attributes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#cache_attributes-1">StoragegatewaySmbFileShare#cache_attributes</a>
        /// </summary>
        [<CustomOperation "cache_attributes">]
        member _.CacheAttributes(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: aws.StoragegatewaySmbFileShare.StoragegatewaySmbFileShareCacheAttributes) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.CacheAttributes <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#case_sensitivity-1">StoragegatewaySmbFileShare#case_sensitivity</a>.
        /// </summary>
        [<CustomOperation "case_sensitivity">]
        member _.CaseSensitivity(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.CaseSensitivity <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#default_storage_class-1">StoragegatewaySmbFileShare#default_storage_class</a>.
        /// </summary>
        [<CustomOperation "default_storage_class">]
        member _.DefaultStorageClass(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.DefaultStorageClass <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#file_share_name-1">StoragegatewaySmbFileShare#file_share_name</a>.
        /// </summary>
        [<CustomOperation "file_share_name">]
        member _.FileShareName(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.FileShareName <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#guess_mime_type_enabled-1">StoragegatewaySmbFileShare#guess_mime_type_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "guess_mime_type_enabled">]
        member _.GuessMimeTypeEnabled(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: bool) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.GuessMimeTypeEnabled <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#guess_mime_type_enabled-1">StoragegatewaySmbFileShare#guess_mime_type_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "guess_mime_type_enabled">]
        member _.GuessMimeTypeEnabled(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.GuessMimeTypeEnabled <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#id-1">StoragegatewaySmbFileShare#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#invalid_user_list-1">StoragegatewaySmbFileShare#invalid_user_list</a>.
        /// </summary>
        [<CustomOperation "invalid_user_list">]
        member _.InvalidUserList(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: seq<string>) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.InvalidUserList <- (value |> Seq.toArray))
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#kms_encrypted-1">StoragegatewaySmbFileShare#kms_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "kms_encrypted">]
        member _.KmsEncrypted(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: bool) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.KmsEncrypted <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#kms_encrypted-1">StoragegatewaySmbFileShare#kms_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "kms_encrypted">]
        member _.KmsEncrypted(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.KmsEncrypted <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#kms_key_arn-1">StoragegatewaySmbFileShare#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#notification_policy-1">StoragegatewaySmbFileShare#notification_policy</a>.
        /// </summary>
        [<CustomOperation "notification_policy">]
        member _.NotificationPolicy(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.NotificationPolicy <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#object_acl-1">StoragegatewaySmbFileShare#object_acl</a>.
        /// </summary>
        [<CustomOperation "object_acl">]
        member _.ObjectAcl(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.ObjectAcl <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#oplocks_enabled-1">StoragegatewaySmbFileShare#oplocks_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "oplocks_enabled">]
        member _.OplocksEnabled(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: bool) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.OplocksEnabled <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#oplocks_enabled-1">StoragegatewaySmbFileShare#oplocks_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "oplocks_enabled">]
        member _.OplocksEnabled(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.OplocksEnabled <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#read_only-1">StoragegatewaySmbFileShare#read_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "read_only">]
        member _.ReadOnly(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: bool) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.ReadOnly <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#read_only-1">StoragegatewaySmbFileShare#read_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "read_only">]
        member _.ReadOnly(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.ReadOnly <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#requester_pays-1">StoragegatewaySmbFileShare#requester_pays</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "requester_pays">]
        member _.RequesterPays(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: bool) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.RequesterPays <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#requester_pays-1">StoragegatewaySmbFileShare#requester_pays</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "requester_pays">]
        member _.RequesterPays(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.RequesterPays <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#smb_acl_enabled-1">StoragegatewaySmbFileShare#smb_acl_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "smb_acl_enabled">]
        member _.SmbAclEnabled(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: bool) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.SmbAclEnabled <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#smb_acl_enabled-1">StoragegatewaySmbFileShare#smb_acl_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "smb_acl_enabled">]
        member _.SmbAclEnabled(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.SmbAclEnabled <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#tags-1">StoragegatewaySmbFileShare#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: seq<string * string>) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#tags_all-1">StoragegatewaySmbFileShare#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: seq<string * string>) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#timeouts-1">StoragegatewaySmbFileShare#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: aws.StoragegatewaySmbFileShare.StoragegatewaySmbFileShareTimeouts) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#valid_user_list-1">StoragegatewaySmbFileShare#valid_user_list</a>.
        /// </summary>
        [<CustomOperation "valid_user_list">]
        member _.ValidUserList(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: seq<string>) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.ValidUserList <- (value |> Seq.toArray))
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#vpc_endpoint_dns_name-1">StoragegatewaySmbFileShare#vpc_endpoint_dns_name</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_dns_name">]
        member _.VpcEndpointDnsName(state: StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>, value: string) : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.VpcEndpointDnsName <- value)
            state : StoragegatewaySmbFileShareState<'GatewayArn, 'LocationArn, 'RoleArn>

        member _.Run(state: StoragegatewaySmbFileShareState<Present, Present, Present>) : aws.StoragegatewaySmbFileShare.StoragegatewaySmbFileShare =
            let config = aws.StoragegatewaySmbFileShare.StoragegatewaySmbFileShareConfig()
            for setter in state.assignments do
                setter config
            aws.StoragegatewaySmbFileShare.StoragegatewaySmbFileShare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.storagegatewaySmbFileShare: missing required arguments. Must call: gateway_arn, location_arn, role_arn.", 9999, IsError = true)>]
        member _.Run(_: StoragegatewaySmbFileShareState<_, _, _>) : aws.StoragegatewaySmbFileShare.StoragegatewaySmbFileShare =
            Unchecked.defaultof<aws.StoragegatewaySmbFileShare.StoragegatewaySmbFileShare>

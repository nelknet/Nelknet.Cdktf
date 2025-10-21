namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftserverlessNamespaceState<'NamespaceName> = { assignments: ResizeArray<aws.RedshiftserverlessNamespace.RedshiftserverlessNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace">aws_redshiftserverless_namespace</a>.
    /// </summary>
    type RedshiftserverlessNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftserverlessNamespaceState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessNamespaceState<Missing>)

        member _.Zero(()) : RedshiftserverlessNamespaceState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessNamespaceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#namespace_name-1">RedshiftserverlessNamespace#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: RedshiftserverlessNamespaceState<Missing>, value: string) : RedshiftserverlessNamespaceState<Present> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : RedshiftserverlessNamespaceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#admin_password_secret_kms_key_id-1">RedshiftserverlessNamespace#admin_password_secret_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "admin_password_secret_kms_key_id">]
        member _.AdminPasswordSecretKmsKeyId(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: string) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.AdminPasswordSecretKmsKeyId <- value)
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#admin_username-1">RedshiftserverlessNamespace#admin_username</a>.
        /// </summary>
        [<CustomOperation "admin_username">]
        member _.AdminUsername(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: string) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.AdminUsername <- value)
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#admin_user_password-1">RedshiftserverlessNamespace#admin_user_password</a>.
        /// </summary>
        [<CustomOperation "admin_user_password">]
        member _.AdminUserPassword(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: string) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.AdminUserPassword <- value)
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#admin_user_password_wo-1">RedshiftserverlessNamespace#admin_user_password_wo</a>.
        /// </summary>
        [<CustomOperation "admin_user_password_wo">]
        member _.AdminUserPasswordWo(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: string) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.AdminUserPasswordWo <- value)
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#admin_user_password_wo_version-1">RedshiftserverlessNamespace#admin_user_password_wo_version</a>.
        /// </summary>
        [<CustomOperation "admin_user_password_wo_version">]
        member _.AdminUserPasswordWoVersion(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: double) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.AdminUserPasswordWoVersion <- value)
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#db_name-1">RedshiftserverlessNamespace#db_name</a>.
        /// </summary>
        [<CustomOperation "db_name">]
        member _.DbName(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: string) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.DbName <- value)
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#default_iam_role_arn-1">RedshiftserverlessNamespace#default_iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "default_iam_role_arn">]
        member _.DefaultIamRoleArn(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: string) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.DefaultIamRoleArn <- value)
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#iam_roles-1">RedshiftserverlessNamespace#iam_roles</a>.
        /// </summary>
        [<CustomOperation "iam_roles">]
        member _.IamRoles(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: seq<string>) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.IamRoles <- (value |> Seq.toArray))
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#id-1">RedshiftserverlessNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: string) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#kms_key_id-1">RedshiftserverlessNamespace#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: string) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#log_exports-1">RedshiftserverlessNamespace#log_exports</a>.
        /// </summary>
        [<CustomOperation "log_exports">]
        member _.LogExports(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: seq<string>) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.LogExports <- (value |> Seq.toArray))
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#manage_admin_password-1">RedshiftserverlessNamespace#manage_admin_password</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_admin_password">]
        member _.ManageAdminPassword(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: bool) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.ManageAdminPassword <- value)
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#manage_admin_password-1">RedshiftserverlessNamespace#manage_admin_password</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_admin_password">]
        member _.ManageAdminPassword(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: HashiCorp.Cdktf.IResolvable) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.ManageAdminPassword <- value)
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#tags-1">RedshiftserverlessNamespace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: seq<string * string>) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_namespace#tags_all-1">RedshiftserverlessNamespace#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RedshiftserverlessNamespaceState<'NamespaceName>, value: seq<string * string>) : RedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RedshiftserverlessNamespaceState<'NamespaceName>

        member _.Run(state: RedshiftserverlessNamespaceState<Present>) : aws.RedshiftserverlessNamespace.RedshiftserverlessNamespace =
            let config = aws.RedshiftserverlessNamespace.RedshiftserverlessNamespaceConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftserverlessNamespace.RedshiftserverlessNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftserverlessNamespace: missing required arguments. Must call: namespace_name.", 9999, IsError = true)>]
        member _.Run(_: RedshiftserverlessNamespaceState<_>) : aws.RedshiftserverlessNamespace.RedshiftserverlessNamespace =
            Unchecked.defaultof<aws.RedshiftserverlessNamespace.RedshiftserverlessNamespace>

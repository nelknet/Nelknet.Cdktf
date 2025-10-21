namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> = { assignments: ResizeArray<aws.TimestreaminfluxdbDbInstance.TimestreaminfluxdbDbInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance">aws_timestreaminfluxdb_db_instance</a>.
    /// </summary>
    type TimestreaminfluxdbDbInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : TimestreaminfluxdbDbInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TimestreaminfluxdbDbInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : TimestreaminfluxdbDbInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TimestreaminfluxdbDbInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// The amount of storage to allocate for your DB storage type in GiB (gibibytes). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#allocated_storage-1">TimestreaminfluxdbDbInstance#allocated_storage</a>
        /// </summary>
        [<CustomOperation "allocated_storage">]
        member _.AllocatedStorage(state: TimestreaminfluxdbDbInstanceState<Missing, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: double) : TimestreaminfluxdbDbInstanceState<Present, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.AllocatedStorage <- value)
            ({ assignments = state.assignments } : TimestreaminfluxdbDbInstanceState<Present, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>)

        /// <summary>
        /// The name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket. A bucket combines the concept of a database and a retention period (the duration of time that each data point persists). A bucket belongs to an organization. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#bucket-1">TimestreaminfluxdbDbInstance#bucket</a>
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, Missing, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: string) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, Present, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, Present, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>)

        /// <summary>
        /// The Timestream for InfluxDB DB instance type to run InfluxDB on. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#db_instance_type-1">TimestreaminfluxdbDbInstance#db_instance_type</a>
        /// </summary>
        [<CustomOperation "db_instance_type">]
        member _.DbInstanceType(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, Missing, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: string) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, Present, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.DbInstanceType <- value)
            ({ assignments = state.assignments } : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, Present, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>)

        /// <summary>
        /// The name that uniquely identifies the DB instance when interacting with the  					Amazon Timestream for InfluxDB API and CLI commands. This name will also be a prefix included in the endpoint. DB instance names must be unique per customer and per region. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#name-1">TimestreaminfluxdbDbInstance#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, Missing, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: string) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, Present, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, Present, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>)

        /// <summary>
        /// The name of the initial organization for the initial admin user in InfluxDB. An InfluxDB organization is a workspace for a group of users. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#organization-1">TimestreaminfluxdbDbInstance#organization</a>
        /// </summary>
        [<CustomOperation "organization">]
        member _.Organization(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, Missing, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: string) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, Present, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Organization <- value)
            ({ assignments = state.assignments } : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, Present, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>)

        /// <summary>
        /// The password of the initial admin user created in InfluxDB. This password will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. These attributes will be stored in a Secret created in AWS SecretManager in your account. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#password-1">TimestreaminfluxdbDbInstance#password</a>
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, Missing, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: string) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, Present, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, Present, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>)

        /// <summary>
        /// The username of the initial admin user created in InfluxDB. Must start with a letter and can't end with a hyphen or contain two consecutive hyphens. For example, my-user1. This username will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. These attributes will be stored in a Secret created in Amazon Secrets Manager in your account Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#username-1">TimestreaminfluxdbDbInstance#username</a>
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, Missing, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: string) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, Present, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, Present, 'VpcSecurityGroupIds, 'VpcSubnetIds>)

        /// <summary>
        /// A list of VPC security group IDs to associate with the DB instance. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#vpc_security_group_ids-1">TimestreaminfluxdbDbInstance#vpc_security_group_ids</a>
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, Missing, 'VpcSubnetIds>, value: seq<string>) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, Present, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, Present, 'VpcSubnetIds>)

        /// <summary>
        /// A list of VPC subnet IDs to associate with the DB instance. Provide at least two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#vpc_subnet_ids-1">TimestreaminfluxdbDbInstance#vpc_subnet_ids</a>
        /// </summary>
        [<CustomOperation "vpc_subnet_ids">]
        member _.VpcSubnetIds(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, Missing>, value: seq<string>) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, Present> =
            state.assignments.Add(fun config -> config.VpcSubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, Present>)

        /// <summary>
        /// The id of the DB parameter group assigned to your DB instance. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#db_parameter_group_identifier-1">TimestreaminfluxdbDbInstance#db_parameter_group_identifier</a>
        /// </summary>
        [<CustomOperation "db_parameter_group_identifier">]
        member _.DbParameterGroupIdentifier(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: string) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.DbParameterGroupIdentifier <- value)
            state : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>

        /// <summary>
        /// The Timestream for InfluxDB DB storage type to read and write InfluxDB data. You can choose between 3 different types of provisioned Influx IOPS included storage according to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS, Influx IO Included 16000 IOPS. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#db_storage_type-1">TimestreaminfluxdbDbInstance#db_storage_type</a>
        /// </summary>
        [<CustomOperation "db_storage_type">]
        member _.DbStorageType(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: string) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.DbStorageType <- value)
            state : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>

        /// <summary>
        /// Specifies whether the DB instance will be deployed as a standalone instance or  					with a Multi-AZ standby for high availability. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#deployment_type-1">TimestreaminfluxdbDbInstance#deployment_type</a>
        /// </summary>
        [<CustomOperation "deployment_type">]
        member _.DeploymentType(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: string) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.DeploymentType <- value)
            state : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>

        /// <summary>
        /// log_delivery_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#log_delivery_configuration-1">TimestreaminfluxdbDbInstance#log_delivery_configuration</a> Accepts: aws.IResolvable | aws.TimestreaminfluxdbDbInstance.TimestreaminfluxdbDbInstanceLogDeliveryConfiguration[]
        /// </summary>
        [<CustomOperation "log_delivery_configuration">]
        member _.LogDeliveryConfiguration(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: HashiCorp.Cdktf.IResolvable) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.LogDeliveryConfiguration <- value)
            state : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>

        /// <summary>
        /// Specifies whether the networkType of the Timestream for InfluxDB instance is  					IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate  					over both IPv4 and IPv6 protocols. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#network_type-1">TimestreaminfluxdbDbInstance#network_type</a>
        /// </summary>
        [<CustomOperation "network_type">]
        member _.NetworkType(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: string) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.NetworkType <- value)
            state : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>

        /// <summary>
        /// The port number on which InfluxDB accepts connections. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#port-1">TimestreaminfluxdbDbInstance#port</a>
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: double) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>

        /// <summary>
        /// Configures the DB instance with a public IP to facilitate access. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#publicly_accessible-1">TimestreaminfluxdbDbInstance#publicly_accessible</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: bool) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>

        /// <summary>
        /// Configures the DB instance with a public IP to facilitate access. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#publicly_accessible-1">TimestreaminfluxdbDbInstance#publicly_accessible</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: HashiCorp.Cdktf.IResolvable) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#tags-1">TimestreaminfluxdbDbInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: seq<string * string>) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#timeouts-1">TimestreaminfluxdbDbInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>, value: aws.TimestreaminfluxdbDbInstance.TimestreaminfluxdbDbInstanceTimeouts) : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : TimestreaminfluxdbDbInstanceState<'AllocatedStorage, 'Bucket, 'DbInstanceType, 'Name, 'Organization, 'Password, 'Username, 'VpcSecurityGroupIds, 'VpcSubnetIds>

        member _.Run(state: TimestreaminfluxdbDbInstanceState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : aws.TimestreaminfluxdbDbInstance.TimestreaminfluxdbDbInstance =
            let config = aws.TimestreaminfluxdbDbInstance.TimestreaminfluxdbDbInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.TimestreaminfluxdbDbInstance.TimestreaminfluxdbDbInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.timestreaminfluxdbDbInstance: missing required arguments. Must call: allocated_storage, bucket, db_instance_type, name, organization, password, username, vpc_security_group_ids, vpc_subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: TimestreaminfluxdbDbInstanceState<_, _, _, _, _, _, _, _, _>) : aws.TimestreaminfluxdbDbInstance.TimestreaminfluxdbDbInstance =
            Unchecked.defaultof<aws.TimestreaminfluxdbDbInstance.TimestreaminfluxdbDbInstance>

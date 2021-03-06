﻿// These are the options to the internal sqlite3_config call.
public enum SqliteOpenOpts {
	SQLITE_OPEN_READONLY = 1,  // Ok for sqlite3_open_v2()
	SQLITE_OPEN_READWRITE = 2,  // Ok for sqlite3_open_v2()
	SQLITE_OPEN_CREATE = 4,  // Ok for sqlite3_open_v2()
	SQLITE_OPEN_DELETEONCLOSE = 8,  // VFS only
	SQLITE_OPEN_EXCLUSIVE = 16,  // VFS only
	SQLITE_OPEN_AUTOPROXY = 32,  // VFS only
	SQLITE_OPEN_URI = 64,  // Ok for sqlite3_open_v2()
	SQLITE_OPEN_MEMORY = 128,  // Ok for sqlite3_open_v2()
	SQLITE_OPEN_MAIN_DB = 256,  // VFS only
	SQLITE_OPEN_TEMP_DB = 512,  // VFS only
	SQLITE_OPEN_TRANSIENT_DB = 1024,  // VFS only
	SQLITE_OPEN_MAIN_JOURNAL = 2048,  // VFS only
	SQLITE_OPEN_TEMP_JOURNAL = 4096,  // VFS only
	SQLITE_OPEN_SUBJOURNAL = 8192,  // VFS only
	SQLITE_OPEN_MASTER_JOURNAL = 16384,  // VFS only
	SQLITE_OPEN_NOMUTEX = 32768,  // Ok for sqlite3_open_v2()
	SQLITE_OPEN_FULLMUTEX = 65536,  // Ok for sqlite3_open_v2()
	SQLITE_OPEN_SHAREDCACHE = 131072,  // Ok for sqlite3_open_v2()
	SQLITE_OPEN_PRIVATECACHE = 262144,  // Ok for sqlite3_open_v2()
	SQLITE_OPEN_WAL = 524288,  // VFS only
}

/// <summary>
/// SQLite error codes.  Actually, this enumeration represents a return code,
/// which may also indicate success in one of several ways (e.g. SQLITE_OK,
/// SQLITE_ROW, and SQLITE_DONE).  Therefore, the name of this enumeration is
/// something of a misnomer.
/// </summary>
public enum SqliteErrorCode {
		INTARRAY_DUPLICATE_NAME	            = 213,
		INTARRAY_INTERNAL_ERROR	            = 212,
		INTARRAY_INUSE	                    = 210,
		SQLITE_ABORT	                    = 4,
		SQLITE_ABORT_ROLLBACK	            = 516,
		SQLITE_AUTH	                        = 23,
		SQLITE_BLOB	                        = 4,
		SQLITE_BUSY	                        = 5,
		SQLITE_BUSY_RECOVERY	            = 261,
		SQLITE_BUSY_SNAPSHOT	            = 517,
		SQLITE_CANTOPEN	                    = 14,
		SQLITE_CANTOPEN_CONVPATH	        = 1038,
		SQLITE_CANTOPEN_FULLPATH	        = 782,
		SQLITE_CANTOPEN_ISDIR	            = 526,
		SQLITE_CANTOPEN_NOTEMPDIR	        = 270,
		SQLITE_CONSTRAINT	                = 19,
		SQLITE_CONSTRAINT_CHECK	            = 275,
		SQLITE_CONSTRAINT_COMMITHOOK	    = 531,
		SQLITE_CONSTRAINT_FOREIGNKEY	    = 787,
		SQLITE_CONSTRAINT_FUNCTION	        = 1043,
		SQLITE_CONSTRAINT_NOTNULL	        = 1299,
		SQLITE_CONSTRAINT_PRIMARYKEY	    = 1555,
		SQLITE_CONSTRAINT_ROWID	            = 2579,
		SQLITE_CONSTRAINT_TRIGGER	        = 1811,
		SQLITE_CONSTRAINT_UNIQUE	        = 2067,
		SQLITE_CONSTRAINT_VTAB	            = 2323,
		SQLITE_CORRUPT	                    = 11,
		SQLITE_CORRUPT_VTAB	                = 267,
		SQLITE_DONE	                        = 101,
		SQLITE_EMPTY	                    = 16,
		SQLITE_ERROR	                    = 1,
		SQLITE_FLOAT	                    = 2,
		SQLITE_FORMAT	                    = 24,
		SQLITE_FULL	                        = 13,
		SQLITE_INTEGER	                    = 1,
		SQLITE_INTERNAL	                    = 2,
		SQLITE_INTERRUPT	                = 9,
		SQLITE_IOERR	                    = 10,
		SQLITE_IOERR_ACCESS	                = 3338,
		SQLITE_IOERR_BLOCKED	            = 2826,
		SQLITE_IOERR_CHECKRESERVEDLOCK	    = 3594,
		SQLITE_IOERR_CLOSE	                = 4106,
		SQLITE_IOERR_CONVPATH	            = 6666,
		SQLITE_IOERR_DELETE	                = 2570,
		SQLITE_IOERR_DELETE_NOENT	        = 5898,
		SQLITE_IOERR_DIR_CLOSE	            = 4362,
		SQLITE_IOERR_DIR_FSYNC	            = 1290,
		SQLITE_IOERR_FSTAT	                = 1802,
		SQLITE_IOERR_FSYNC	                = 1034,
		SQLITE_IOERR_GETTEMPPATH	        = 6410,
		SQLITE_IOERR_LOCK	                = 3850,
		SQLITE_IOERR_MMAP	                = 6154,
		SQLITE_IOERR_NOMEM	                = 3082,
		SQLITE_IOERR_RDLOCK	                = 2314,
		SQLITE_IOERR_READ	                = 266,
		SQLITE_IOERR_SEEK	                = 5642,
		SQLITE_IOERR_SHMLOCK	            = 5130,
		SQLITE_IOERR_SHMMAP	                = 5386,
		SQLITE_IOERR_SHMOPEN	            = 4618,
		SQLITE_IOERR_SHMSIZE	            = 4874,
		SQLITE_IOERR_SHORT_READ	            = 522,
		SQLITE_IOERR_TRUNCATE	            = 1546,
		SQLITE_IOERR_UNLOCK	                = 2058,
		SQLITE_IOERR_WRITE	                = 778,
		SQLITE_LIMIT_ATTACHED	            = 7,
		SQLITE_LIMIT_COLUMN	                = 2,
		SQLITE_LIMIT_COMPOUND_SELECT	    = 4,
		SQLITE_LIMIT_EXPR_DEPTH	            = 3,
		SQLITE_LIMIT_FUNCTION_ARG	        = 6,
		SQLITE_LIMIT_LENGTH	                = 0,
		SQLITE_LIMIT_LIKE_PATTERN_LENGTH	= 8,
		SQLITE_LIMIT_SQL_LENGTH	            = 1,
		SQLITE_LIMIT_TRIGGER_DEPTH	        = 10,
		SQLITE_LIMIT_VARIABLE_NUMBER	    = 9,
		SQLITE_LIMIT_VDBE_OP	            = 5,
		SQLITE_LOCKED	                    = 6,
		SQLITE_LOCKED_SHAREDCACHE	        = 262,
		SQLITE_MISMATCH	                    = 20,
		SQLITE_MISUSE	                    = 21,
		SQLITE_NOLFS	                    = 22,
		SQLITE_NOMEM	                    = 7,
		SQLITE_NOTADB	                    = 26,
		SQLITE_NOTFOUND	                    = 12,
		SQLITE_NOTICE	                    = 27,
		SQLITE_NOTICE_RECOVER_ROLLBACK	    = 539,
		SQLITE_NOTICE_RECOVER_WAL	        = 283,
		SQLITE_NULL	                        = 5,
		SQLITE_OK	                        = 0,
		SQLITE_OPEN_AUTOPROXY	            = 32,
		SQLITE_OPEN_CREATE	                = 4,
		SQLITE_OPEN_DELETEONCLOSE	        = 8,
		SQLITE_OPEN_EXCLUSIVE	            = 16,
		SQLITE_OPEN_FULLMUTEX	            = 65536,
		SQLITE_OPEN_MAIN_DB	                = 256,
		SQLITE_OPEN_MAIN_JOURNAL	        = 2048,
		SQLITE_OPEN_MASTER_JOURNAL	        = 16384,
		SQLITE_OPEN_MEMORY	                = 128,
		SQLITE_OPEN_NOMUTEX	                = 32768,
		SQLITE_OPEN_PRIVATECACHE	        = 262144,
		SQLITE_OPEN_READONLY	            = 1,
		SQLITE_OPEN_READWRITE	            = 2,
		SQLITE_OPEN_SHAREDCACHE	            = 131072,
		SQLITE_OPEN_SUBJOURNAL	            = 8192,
		SQLITE_OPEN_TEMP_DB	                = 512,
		SQLITE_OPEN_TEMP_JOURNAL	        = 4096,
		SQLITE_OPEN_TRANSIENT_DB	        = 1024,
		SQLITE_OPEN_URI	                    = 64,
		SQLITE_OPEN_WAL	                    = 524288,
		SQLITE_PERM	                        = 3,
		SQLITE_PROTOCOL	                    = 15,
		SQLITE_RANGE	                    = 25,
		SQLITE_READONLY	                    = 8,
		SQLITE_READONLY_CANTLOCK	        = 520,
		SQLITE_READONLY_DBMOVED	            = 1032,
		SQLITE_READONLY_RECOVERY	        = 264,
		SQLITE_READONLY_ROLLBACK	        = 776,
		SQLITE_ROW	                        = 100,
		SQLITE_SCHEMA	                    = 17,
		SQLITE_TEXT	                        = 3,
		SQLITE_TOOBIG	                    = 18,
		SQLITE_WARNING	                    = 28,
		SQLITE_WARNING_AUTOINDEX	        = 284,
	}
	
public enum SqliteDatatype {
	SQLITE_INTEGER = 1,
	SQLITE_FLOAT   = 2,
	SQLITE_TEXT    = 3,
	SQLITE_BLOB    = 4,
	SQLITE_NULL    = 5
}

// These are the options to the internal sqlite3_config call.
public enum SqliteConfigOps {
	SQLITE_CONFIG_NONE = 0, // nil
	SQLITE_CONFIG_SINGLETHREAD = 1, // nil
	SQLITE_CONFIG_MULTITHREAD = 2, // nil
	SQLITE_CONFIG_SERIALIZED = 3, // nil
	SQLITE_CONFIG_MALLOC = 4, // sqlite3_mem_methods*
	SQLITE_CONFIG_GETMALLOC = 5, // sqlite3_mem_methods*
	SQLITE_CONFIG_SCRATCH = 6, // void*, int sz, int N
	SQLITE_CONFIG_PAGECACHE = 7, // void*, int sz, int N
	SQLITE_CONFIG_HEAP = 8, // void*, int nByte, int min
	SQLITE_CONFIG_MEMSTATUS = 9, // boolean
	SQLITE_CONFIG_MUTEX = 10, // sqlite3_mutex_methods*
	SQLITE_CONFIG_GETMUTEX = 11, // sqlite3_mutex_methods*
	// previously SQLITE_CONFIG_CHUNKALLOC 12 which is now unused
	SQLITE_CONFIG_LOOKASIDE = 13, // int int
	SQLITE_CONFIG_PCACHE = 14, // sqlite3_pcache_methods*
	SQLITE_CONFIG_GETPCACHE = 15, // sqlite3_pcache_methods*
	SQLITE_CONFIG_LOG = 16, // xFunc, void*
	SQLITE_CONFIG_URI = 17, // int
	SQLITE_CONFIG_PCACHE2 = 18, // sqlite3_pcache_methods2*
	SQLITE_CONFIG_GETPCACHE2 = 19, // sqlite3_pcache_methods2*
	SQLITE_CONFIG_COVERING_INDEX_SCAN = 20, // int
	SQLITE_CONFIG_SQLLOG = 21, // xSqllog, void*
	SQLITE_CONFIG_MMAP_SIZE = 22, // sqlite3_int64, sqlite3_int64
	SQLITE_CONFIG_WIN32_HEAPSIZE = 23 // int nByte
}


MACRO(YarpProgram name)


FOREACH(X ${NEED_LIBS})
	INCLUDE_DIRECTORIES(${CMAKE_SOURCE_DIR}/src/lib${X}/include)
ENDFOREACH(X ${NEED_LIBS})
SET(header_path ${CMAKE_SOURCE_DIR}/src/lib${name}/include)
INCLUDE_DIRECTORIES(${header_path})


FILE(GLOB folder_source *.cpp)
FILE(GLOB folder_header *.h)
SOURCE_GROUP("Source Files" FILES ${folder_source})
SOURCE_GROUP("Header Files" FILES ${folder_header})


ADD_EXECUTABLE(${name} ${folder_source} ${folder_header})


TARGET_LINK_LIBRARIES(${name} ${NEED_LIBS} ${ACE_LINK_FLAGS})


ENDMACRO(YarpProgram)


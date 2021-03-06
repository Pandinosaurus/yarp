# Copyright (C) 2006-2021 Istituto Italiano di Tecnologia (IIT)
# All rights reserved.
#
# This software may be modified and distributed under the terms of the
# BSD-3-Clause license. See the accompanying LICENSE file for details.

add_executable(harness_dev)
target_sources(harness_dev PRIVATE AnalogWrapperTest.cpp
                                   ControlBoardRemapperTest.cpp
                                   ControlBoardWrapper2Test.cpp
                                   FrameTransformClientTest.cpp
                                   GroupDriverTest.cpp
                                   MapGrid2DTest.cpp
                                   Navigation2DClientTest.cpp
                                   MultipleAnalogSensorsInterfacesTest.cpp
                                   PolyDriverTest.cpp
                                   robotDescriptionTest.cpp
                                   fakeFrameGrabberTest.cpp)

target_link_libraries(harness_dev PRIVATE YARP_harness
                                          YARP::YARP_os
                                          YARP::YARP_sig
                                          YARP::YARP_dev)

if(TARGET YARP::YARP_math)
  target_link_libraries(harness_dev PRIVATE YARP::YARP_math)
else()
  set(_disabled_files FrameTransformClientTest.cpp
                      Navigation2DClientTest.cpp
                      MapGrid2DTest.cpp)
  set_source_files_properties(${_disabled_files} PROPERTIES HEADER_FILE_ONLY ON)
endif()

set_property(TARGET harness_dev PROPERTY FOLDER "Test")

yarp_catch_discover_tests(harness_dev)
